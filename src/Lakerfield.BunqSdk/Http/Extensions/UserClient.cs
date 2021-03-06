﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Lakerfield.BunqSdk.Json;
using Lakerfield.BunqSdk.Model;

namespace Lakerfield.BunqSdk.Http
{
  public class UserClient
  {
    /// <summary>
    /// Endpoint name.
    /// </summary>
    private const string ENDPOINT_URL_POST = "user";
    
    public BunqHttpClient Client { get; }

    public UserClient(BunqHttpClient client)
    {
      Client = client;
    }


    public async Task<BunqResponse> Get()
    {
      var request = new HttpRequestMessage(HttpMethod.Get, ENDPOINT_URL_POST)
      {
      };

      var response = await Client.BunqSendAsync(request);

      var userLight = response.Get<Model.UserLight>();
      var userPerson = response.Get<Model.UserPerson>();
      var userCompany = response.Get<Model.UserCompany>();
      var userApiKey = response.Get<Model.UserApiKey>();

      return response;
    }


  }

  public static class UserClientExtensions
  {
    public static UserClient User(this BunqHttpClient client)
    {
      return new UserClient(client);
    }
  }

}
