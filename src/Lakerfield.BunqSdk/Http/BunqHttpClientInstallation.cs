using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Lakerfield.BunqSdk.Context;
using Lakerfield.BunqSdk.Json;
using Lakerfield.BunqSdk.Model;

namespace Lakerfield.BunqSdk.Http
{
  public class BunqHttpClientInstallation
  {
    /// <summary>
    /// Endpoint name.
    /// </summary>
    private const string ENDPOINT_URL_POST = "/v1/installation";

    public BunqHttpClient Client { get; }

    public BunqHttpClientInstallation(BunqHttpClient client)
    {
      Client = client;
    }


    /// <summary>
    /// This is the only API call that does not require you to use the
    /// "X-Bunq-Client-Authentication" and "X-Bunq-Client-Signature" headers. You
    /// provide the server with the public part of the key pair that you are going
    /// to use to create the value of the signature header for all future API
    /// calls. The server creates an installation for you. Store the Installation
    /// Token and ServerPublicKey from the response. This token is used in the
    /// "X-Bunq-Client-Authentication" header for the creation of a DeviceServer
    /// and SessionServer.
    /// </summary>
    public async Task<BunqResponse> Create(string publicKeyClientString)
    {
      try
      {
        var requestData = new ClientPublicKey()
        {
          Value = publicKeyClientString
        };

        var request = new HttpRequestMessage(HttpMethod.Post, ENDPOINT_URL_POST)
        {
          Content = new StringContent(BunqJsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json")
        };

        var response = await Client.BunqSendAsync(request);

        //var id = response.Get<Model.Id>();
        //var token = response.Get<Model.Token>();
        //var serverPublicKey = response.Get<Model.ServerPublicKey>();

        return response;
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        throw;
      }
    }

    public async Task<BunqResponse> Get()
    {
      try
      {
        var request = new HttpRequestMessage(HttpMethod.Get, ENDPOINT_URL_POST);

        var response = await Client.BunqSendAsync(request);

        var id = response.Get<Model.Id>();

        return response;
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        throw;
      }
    }
  }

  public static class BunqHttpClientInstallationExtensions
  {
    public static BunqHttpClientInstallation Installation(this BunqHttpClient client)
    {
      return new BunqHttpClientInstallation(client);
    }
  }

}
