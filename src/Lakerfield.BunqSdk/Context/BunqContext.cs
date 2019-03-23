using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lakerfield.BunqSdk.Http;
using Lakerfield.BunqSdk.Store;

namespace Lakerfield.BunqSdk.Context
{
  public class BunqContext
  {
    public User UserStore { get; }
    public BunqHttpClient Client { get; set; }

    public ApiContext Api { get; set; }

    public BunqContext(User userStore)
    {
      UserStore = userStore;
      Client = new BunqHttpClient(UserStore);
    }


    public async Task Setup()
    {
      if (string.IsNullOrWhiteSpace(UserStore.ApiKey))
      {
        switch (UserStore.Environment)
        {
          case BunqEnvironment.Sandbox:
            UserStore.ApiKey = await GenerateNewSandboxUserApiKey();
            Api = await ApiContext.Create(UserStore, Client, Environment.MachineName);
            break;

          case BunqEnvironment.Production:
          default:
            throw new ArgumentOutOfRangeException("ApiKey is missing");
        }
      }

      Api = new ApiContext(UserStore, Client);




    }

    public async Task<string> GenerateNewSandboxUserApiKey()
    {
      var client = new BunqHttpClient(UserStore);
      var sandboxClient = client.SandboxUser();

      var apiKey = await sandboxClient.GetNewApiKey();
      return apiKey.Value;
    }

  }
}
