using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Bunq.Sdk.Security;
using Lakerfield.BunqSdk.Http;
using Lakerfield.BunqSdk.Model;
using Lakerfield.BunqSdk.Store;

namespace Lakerfield.BunqSdk.Context
{
  public class ApiContext
  {
    public User UserStore { get; }
    public BunqHttpClient Client { get; }

    public InstallationContext InstallationContext { get; private set; }
    //public SessionContext SessionContext { get; private set; }



    private ApiContext(User userStore, BunqHttpClient client)
    {
      UserStore = userStore;
      Client = client;
    }

    public static async Task<ApiContext> Create(User userStore, BunqHttpClient client, string deviceDescription)
    {
      var apiContext = new ApiContext(userStore, client);
      await apiContext.InitializeInstallationContext();



      return apiContext;
    }


    private async Task InitializeInstallationContext()
    {
      var keyPairClient = SecurityUtils.GenerateKeyPair();
      var publicKeyFormattedString = SecurityUtils.GetPublicKeyFormattedString(keyPairClient);

      UserStore.Installation.ClientKeyPair = keyPairClient;

      var installationClient = Client.Installation();

      var result = await installationClient.Create(this, publicKeyFormattedString);

      var sessionToken = result.Get<Token>();
      var serverPublicKey = result.Get<ServerPublicKey>();

      UserStore.Installation.Token = sessionToken.Value;
      UserStore.Installation.ServerPublicKey = SecurityUtils.CreatePublicKeyFromPublicKeyFormattedString(serverPublicKey.Value);

      InstallationContext = new InstallationContext(sessionToken, serverPublicKey, keyPairClient);
    }

  }
}
