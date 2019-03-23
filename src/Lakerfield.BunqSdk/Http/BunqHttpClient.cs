using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Bunq.Sdk.Exception;
using Bunq.Sdk.Security;
using Lakerfield.BunqSdk.Context;
using Lakerfield.BunqSdk.Json;
using Lakerfield.BunqSdk.Model;
using Lakerfield.BunqSdk.Store;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Lakerfield.BunqSdk.Http
{
  public class BunqHttpClient : HttpClient
  {
    public User UserStore { get; }

    /// <summary>
    /// Field constants.
    /// </summary>
    private const string FIELD_RESPONSE = "Response";

    private const string FIELD_ID = "Id";
    private const string FIELD_UUID = "Uuid";
    private const string FIELD_PAGINATION = "Pagination";

    /// <summary>
    /// Index of the very first item in an array.
    /// </summary>
    private const int INDEX_FIRST = 0;




    public BunqHttpClient(User userStore) : base(new LoggingHandler(new HttpClientHandler()))
    {
      UserStore = userStore;
      this.BaseAddress = new Uri(Constants.GetEnvironmentBaseUri(userStore.Environment));
    }


    

    public async Task<BunqResponse> BunqSendAsync(HttpRequestMessage request)
    {
      //TODO check if session ready
      if (NeedsSession(request.RequestUri))
      {
        
      }

      SetDefaultHeaders(request);
      //SetHeaders(request, customHeaders);
      SetSessionHeaders(request);

      //var responseMessage = client.SendAsync(requestMessage).Result;
      var response = await SendAsync(request);

      AssertResponseSuccess(response);
      ValidateResponse(response);

      var json = await response.Content.ReadAsStringAsync();
      //var json = Encoding.UTF8.GetString(responseRaw.BodyBytes);

      var jObject = BunqJsonConvert.DeserializeObject<JObject>(json);
      var responseArray = (JArray)jObject.GetValue(FIELD_RESPONSE);

      //TODO: response.Headers;

      return new BunqResponse(responseArray);
    }


    private static void SetDefaultHeaders(HttpRequestMessage requestMessage)
    {
      SetHeaders(requestMessage, GetDefaultHeaders());
    }

    private static void SetHeaders(HttpRequestMessage requestMessage, IDictionary<string, string> headersToAdd)
    {
      foreach (var header in headersToAdd)
      {
        if (IsHeaderSet(requestMessage.Headers, header.Key)) continue;
        if (requestMessage.Headers.TryAddWithoutValidation(header.Key, header.Value)) continue;
        if (IsHeaderSet(requestMessage.Content.Headers, header.Key)) continue;

        requestMessage.Content.Headers.TryAddWithoutValidation(header.Key, header.Value);
      }
    }

    private static bool IsHeaderSet(HttpHeaders headers, string headerName)
    {
      IEnumerable<string> dummyOut;

      return headers.TryGetValues(headerName, out dummyOut);
    }

    private static IDictionary<string, string> GetDefaultHeaders()
    {
      return new SortedDictionary<string, string>
      {
        {BunqHeaders.HEADER_USER_AGENT, BunqHeaders.USER_AGENT_BUNQ},
        {BunqHeaders.HEADER_REQUEST_ID, GenerateRandomRequestId()},
        {BunqHeaders.HEADER_GEOLOCATION, BunqHeaders.GEOLOCATION_ZERO},
        {BunqHeaders.HEADER_LANGUAGE, BunqHeaders.LANGUAGE_EN_US},
        {BunqHeaders.HEADER_REGION, BunqHeaders.REGION_NL_NL},
        {BunqHeaders.HEADER_CACHE_CONTROL, BunqHeaders.CACHE_CONTROL_NONE}
      };
    }

    private static string GenerateRandomRequestId()
    {
      return Guid.NewGuid().ToString();
    }


    private void SetSessionHeaders(HttpRequestMessage requestMessage)
    {
      var sessionToken = GetSessionToken();

      if (string.IsNullOrWhiteSpace(sessionToken))
        return;

      requestMessage.Headers.Add(BunqHeaders.HEADER_AUTHENTICATION, sessionToken);
      requestMessage.Headers.Add(BunqHeaders.HEADER_SIGNATURE, GenerateSignature(requestMessage));
    }

    private string GenerateSignature(HttpRequestMessage requestMessage)
    {
      return SecurityUtils.GenerateSignature(requestMessage, UserStore.Installation.ClientKeyPair);
    }

    /// <returns> The session token, installation token if the session isn't created yet, or null if no installation
    /// is created either. </returns>
    public string GetSessionToken()
    {
      if (!string.IsNullOrWhiteSpace(UserStore.Session.Token))
        return UserStore.Session.Token;

      if (!string.IsNullOrWhiteSpace(UserStore.Installation.Token))
        return UserStore.Installation.Token;

      return null;
    }



    private bool NeedsSession(Uri uri)
    {
      foreach (var part in BunqHeaders.URIS_NOT_REQUIRING_ACTIVE_SESSION)
      {
        //TODO better
        if (uri.ToString().Contains(part))
          return false;
      }
      return true;
    }


    private static void AssertResponseSuccess(HttpResponseMessage responseMessage)
    {
      if (responseMessage.IsSuccessStatusCode) return;

      var responseCode = (int)responseMessage.StatusCode;
      var responseBody = responseMessage.Content.ReadAsStringAsync().Result;

      throw CreateApiExceptionRequestUnsuccessful(
        responseCode,
        responseBody,
        DetermineResponseIdByAllHeader(responseMessage.Headers)
      );
    }

    private static string DetermineResponseIdByAllHeader(HttpHeaders allHeader)
    {
      if (allHeader.Contains(BunqHeaders.HEADER_RESPONSE_ID_UPPER_CASE))
      {
        return allHeader.GetValues(BunqHeaders.HEADER_RESPONSE_ID_UPPER_CASE).First();
      }
      else if (allHeader.Contains(BunqHeaders.HEADER_RESPONSE_ID_LOWER_CASE))
      {
        return allHeader.GetValues(BunqHeaders.HEADER_RESPONSE_ID_LOWER_CASE).First();
      }
      else
      {
        return BunqHeaders.ERROR_COULD_NOT_DETERMINE_RESPONSE_ID_HEADER;
      }
    }

    private static ApiException CreateApiExceptionRequestUnsuccessful(
      int responseCode,
      string responseBody,
      string responseId
    )
    {
      try
      {
        return ExceptionFactory.CreateExceptionForResponse(
          responseCode,
          FetchErrorDescriptions(responseBody),
          responseId
        );
      }
      catch (JsonException)
      {
        return ExceptionFactory.CreateExceptionForResponse(
          responseCode,
          new List<string> { responseBody },
          responseId
        );
      }
    }

    private static IList<string> FetchErrorDescriptions(string responseBody)
    {
      var responseBodyObject = BunqJsonConvert.DeserializeObject<JObject>(responseBody);

      return responseBodyObject[BunqHeaders.FIELD_ERROR] == null
        ? new List<string> { responseBody }
        : FetchErrorDescriptions(responseBodyObject);
    }

    private static IList<string> FetchErrorDescriptions(JObject responseBodyObject)
    {
      return responseBodyObject
        .GetValue(BunqHeaders.FIELD_ERROR).ToObject<JArray>()
        .Select(exceptionBody => exceptionBody.ToObject<JObject>())
        .Select(exceptionBodyJson => exceptionBodyJson.GetValue(BunqHeaders.FIELD_ERROR_DESCRIPTION).ToString())
        .ToList();
    }



    private void ValidateResponse(HttpResponseMessage responseMessage)
    {
      var serverPublicKey = UserStore.Installation.ServerPublicKey;

      if (serverPublicKey != null)
      {
        SecurityUtils.ValidateResponse(responseMessage, serverPublicKey);
      }
    }




  }
}
