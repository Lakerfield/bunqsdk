using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lakerfield.BunqSdk.Exceptions;
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


    public async Task Setup(bool fastValidation = false)
    {
      if (string.IsNullOrWhiteSpace(UserStore.ApiKey) && UserStore.Environment == BunqEnvironment.Sandbox)
        UserStore.ApiKey = await RequestNewSandboxApiKey();

      if (string.IsNullOrWhiteSpace(UserStore.ApiKey))
        throw new BunqException("ApiKey is missing");

      Api = new ApiContext(UserStore, Client);

      if (!await Api.IsInstallationValid(fastValidation))
        await Api.InitializeInstallation();

      if (!await Api.IsDeviceValid(fastValidation))
        await Api.RegisterDevice(Environment.MachineName, new List<string>());

      await Api.EnsureSessionActive();
    }

    public async Task<string> RequestNewSandboxApiKey()
    {
      var client = new BunqHttpClient(UserStore);
      var sandboxClient = client.SandboxUser();

      var apiKey = await sandboxClient.GetNewApiKey();
      return apiKey.Value;
    }

  }
}
