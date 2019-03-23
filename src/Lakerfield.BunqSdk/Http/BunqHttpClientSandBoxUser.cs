using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Lakerfield.BunqSdk.Model;

namespace Lakerfield.BunqSdk.Http
{
  public class BunqHttpClientSandBoxUser
  {
    /// <summary>
    /// Endpoint name.
    /// </summary>
    private const string ENDPOINT_URL_POST = "/v1/sandbox-user";
    
    public BunqHttpClient Client { get; }

    public BunqHttpClientSandBoxUser(BunqHttpClient client)
    {
      Client = client;
    }


    public async Task<ApiKey> GetNewApiKey()
    {
      var request = new HttpRequestMessage(HttpMethod.Post, ENDPOINT_URL_POST)
      {
      };
      request.Headers.Add("X-Bunq-Client-Request-Id", "unique");
      request.Headers.Add("Cache-Control", "no");
      request.Headers.Add("X-Bunq-Geolocation", "0 0 0 0 NL");
      request.Headers.Add("X-Bunq-Language", "en_US");
      request.Headers.Add("X-Bunq-Region", "en_US");
      request.Headers.Add("User-Agent", "hoi");

      var response = await Client.BunqSendAsync(request);

      var apiKey = response.Get<Model.ApiKey>();

      return apiKey;
    }

  }

  public static class BunqHttpClientSandBoxUserExtensions
  {
    public static BunqHttpClientSandBoxUser SandboxUser(this BunqHttpClient client)
    {
      return new BunqHttpClientSandBoxUser(client);
    }
  }

}
