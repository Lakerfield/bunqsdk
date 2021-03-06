﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Lakerfield.BunqSdk.Json;
using Lakerfield.BunqSdk.Model;

namespace Lakerfield.BunqSdk.Http
{
  public class SessionServerClient
  {
    /// <summary>
    /// Endpoint name.
    /// </summary>
    private const string ENDPOINT_URL_POST = "session-server";
    
    public BunqHttpClient Client { get; }

    public SessionServerClient(BunqHttpClient client)
    {
      Client = client;
    }


    public async Task<BunqResponse> Initialize(string secret)
    {
      var data = new SessionServer()
      {
        Secret = secret,
      };

      var request = new HttpRequestMessage(HttpMethod.Post, ENDPOINT_URL_POST)
      {
        Content = new StringContent(BunqJsonConvert.SerializeObject(data), Encoding.UTF8),
      };

      var response = await Client.BunqSendAsync(request);

      var id = response.Get<Model.BunqId>();
      var token = response.Get<Model.InstallationToken>();
      var userPerson = response.Get<Model.UserPerson>();

      return response;
    }


    public Task Delete(int id)
    {
      throw new NotImplementedException();
    }
  }

  public static class SessionServerClientExtensions
  {
    public static SessionServerClient SessionServer(this BunqHttpClient client)
    {
      return new SessionServerClient(client);
    }
  }

}
