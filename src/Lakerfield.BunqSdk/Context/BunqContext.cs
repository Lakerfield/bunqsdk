using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Lakerfield.BunqSdk.Http;

namespace Lakerfield.BunqSdk.Context
{
  public class BunqContext
  {
    public ApiEnvironmentType EnvironmentType { get; }

    public BunqContext(ApiEnvironmentType environmentType)
    {
      EnvironmentType = environmentType;
    }

    


    public async Task Setup()
    {
      await GenerateNewSandboxUser();
    }



    //private SandboxUser GenerateNewSandboxUser()
    public async Task GenerateNewSandboxUser()
    {
      //var httpClient = new HttpClient();
      var httpClient = new BunqHttpClient(EnvironmentType);
      httpClient.DefaultRequestHeaders.Add("X-Bunq-Client-Request-Id", "unique");
      httpClient.DefaultRequestHeaders.Add("Cache-Control", "no");
      httpClient.DefaultRequestHeaders.Add("X-Bunq-Geolocation", "0 0 0 0 NL");
      httpClient.DefaultRequestHeaders.Add("X-Bunq-Language", "en_US");
      httpClient.DefaultRequestHeaders.Add("X-Bunq-Region", "en_US");
      httpClient.DefaultRequestHeaders.Add("User-Agent", "hoi");

      var response = await httpClient.PostAsync("https://sandbox.bunq.com/v1/sandbox-user", null);

      //var responseString = requestTask.Result.Content.ReadAsStringAsync().Result;
      //var responseJson = BunqJsonConvert.DeserializeObject<JObject>(responseString);
      //return BunqJsonConvert.DeserializeObject<SandboxUser>(responseJson.First.First.First.First.First.ToString());
    }

  }
}
