using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Lakerfield.BunqSdk.Json;
using Lakerfield.BunqSdk.Model;

namespace Lakerfield.BunqSdk.Http
{
  public class DeviceServerClient
  {
    /// <summary>
    /// Endpoint name.
    /// </summary>
    private const string ENDPOINT_URL_POST = "device-server";
    
    public BunqHttpClient Client { get; }

    public DeviceServerClient(BunqHttpClient client)
    {
      Client = client;
    }


    public async Task<BunqResponse> Register(string description, string secret)
    {
      var data = new DeviceServer()
      {
        Description = description,
        Secret = secret,
        //PermittedIps 
      };

      var request = new HttpRequestMessage(HttpMethod.Post, ENDPOINT_URL_POST)
      {
        Content = new ByteArrayContent(Encoding.UTF8.GetBytes(BunqJsonConvert.SerializeObject(data, Formatting.Indented))),
      };

      var response = await Client.BunqSendAsync(request);

      return response;
    }


  }

  public static class DeviceServerClientExtensions
  {
    public static DeviceServerClient DeviceServer(this BunqHttpClient client)
    {
      return new DeviceServerClient(client);
    }
  }

}
