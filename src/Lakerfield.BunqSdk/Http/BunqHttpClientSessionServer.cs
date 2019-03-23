using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Lakerfield.BunqSdk.Json;
using Lakerfield.BunqSdk.Model;

namespace Lakerfield.BunqSdk.Http
{
  public class BunqHttpClientSessionServer
  {
    /// <summary>
    /// Endpoint name.
    /// </summary>
    private const string ENDPOINT_URL_POST = "/v1/session-server";
    
    public BunqHttpClient Client { get; }

    public BunqHttpClientSessionServer(BunqHttpClient client)
    {
      Client = client;
    }


    public async Task<BunqResponse> Initialize(string secret)
    {
      var data = new SessionServerInitialize()
      {
        Secret = secret,
      };

      var request = new HttpRequestMessage(HttpMethod.Post, ENDPOINT_URL_POST)
      {
        Content = new StringContent(BunqJsonConvert.SerializeObject(data), Encoding.UTF8),
      };

      var response = await Client.BunqSendAsync(request);

      var id = response.Get<Model.Id>();
      var token = response.Get<Model.Token>();
      var userPerson = response.Get<Model.UserPerson>();

      return response;
    }


    public Task Delete(int id)
    {
      throw new NotImplementedException();
    }
  }

  public static class BunqHttpClientSessionServerExtensions
  {
    public static BunqHttpClientSessionServer SessionServer(this BunqHttpClient client)
    {
      return new BunqHttpClientSessionServer(client);
    }
  }

}
