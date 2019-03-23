using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Lakerfield.BunqSdk.Context;
using Lakerfield.BunqSdk.Json;
using Lakerfield.BunqSdk.Model;
using Newtonsoft.Json.Linq;

namespace Lakerfield.BunqSdk.Http
{
  public class BunqHttpClient : HttpClient
  {

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


    public BunqHttpClient(BunqEnvironment environment) : base(new LoggingHandler(new HttpClientHandler()))
    {
      this.BaseAddress = new Uri(Constants.GetEnvironmentBaseUri(environment));


    }


    

    public async Task<BunqResponse> BunqSendAsync(HttpRequestMessage request)
    {
      var response = await SendAsync(request);

      var json = await response.Content.ReadAsStringAsync();
      //var json = Encoding.UTF8.GetString(responseRaw.BodyBytes);

      var jObject = BunqJsonConvert.DeserializeObject<JObject>(json);
      var responseArray = (JArray)jObject.GetValue(FIELD_RESPONSE);

      //TODO: response.Headers;

      return new BunqResponse(responseArray);
    }


  }
}
