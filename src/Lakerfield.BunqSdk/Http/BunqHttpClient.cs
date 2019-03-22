using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Lakerfield.BunqSdk.Context;

namespace Lakerfield.BunqSdk.Http
{
  public class BunqHttpClient : HttpClient
  {

    public BunqHttpClient(ApiEnvironmentType environmentType) : base(new LoggingHandler(new HttpClientHandler()))
    {
      this.BaseAddress = new Uri(environmentType.BaseUri);


    }



  }
}
