using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Lakerfield.BunqSdk.Json;
using Lakerfield.BunqSdk.Model;

namespace Lakerfield.BunqSdk.Http
{
  public class BunqHttpClientDeviceServer
  {
    /// <summary>
    /// Endpoint name.
    /// </summary>
    private const string ENDPOINT_URL_POST = "/v1/device-server";
    
    public BunqHttpClient Client { get; }

    public BunqHttpClientDeviceServer(BunqHttpClient client)
    {
      Client = client;
    }


    public async Task<Id> Register(string description, string secret)
    {
      var data = new DeviceServerInternal()
      {
        Description = description,
        Secret = secret,
        //PermittedIps 
      };

      var request = new HttpRequestMessage(HttpMethod.Post, ENDPOINT_URL_POST)
      {
        Content = new StringContent(BunqJsonConvert.SerializeObject(data), Encoding.UTF8),
      };

      var response = await Client.BunqSendAsync(request);

      var id = response.Get<Model.Id>();

      return id;
    }


  }

  public static class BunqHttpClientDeviceServerExtensions
  {
    public static BunqHttpClientDeviceServer DeviceServer(this BunqHttpClient client)
    {
      return new BunqHttpClientDeviceServer(client);
    }
  }

}
