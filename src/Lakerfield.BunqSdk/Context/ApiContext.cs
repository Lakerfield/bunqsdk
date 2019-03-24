using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Lakerfield.BunqSdk.Exceptions;
using Lakerfield.BunqSdk.Http;
using Lakerfield.BunqSdk.Model;
using Lakerfield.BunqSdk.Security;
using Lakerfield.BunqSdk.Store;

namespace Lakerfield.BunqSdk.Context
{
  public class ApiContext
  {
    public User UserStore { get; }
    public BunqHttpClient Client { get; }

    /// <summary>
    /// Measure of any time unit when none of it is needed.
    /// </summary>
    private const int TIME_UNIT_COUNT_NONE = 0;

    /// <summary>
    /// Minimum time to session expiry not requiring session reset.
    /// </summary>
    private const int TIME_TO_SESSION_EXPIRY_MINIMUM_SECONDS = 30;

    /// <summary>
    /// Default path to store the serialized context.
    /// </summary>
    private const string PATH_API_CONTEXT_DEFAULT = "bunq.conf";

    /// <summary>
    /// Dummy ID to pass to Session endpoint.
    /// </summary>
    private const int SESSION_ID_DUMMY = 0;


    internal ApiContext(User userStore, BunqHttpClient client)
    {
      UserStore = userStore;
      Client = client;
    }

    internal async Task<bool> IsInstallationValid(bool fastValidation)
    {
      var installation = UserStore.Installation;
      if (installation.ClientKeyPair == null ||
          installation.ServerPublicKey == null ||
          string.IsNullOrWhiteSpace(installation.Token))
        return false;

      if (fastValidation)
        return true;

      try
      {
        var installationClient = Client.Installation();
        var result = await installationClient.Get();//UserStore.Installation.Id

        return true;
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        return false;
      }
    }

    internal async Task InitializeInstallation()
    {
      var keyPairClient = SecurityUtils.GenerateKeyPair();

      var installationClient = Client.Installation();
      var result = await installationClient.Create(SecurityUtils.GetPublicKeyFormattedString(keyPairClient));

      var id = result.Get<Id>();
      var sessionToken = result.Get<Token>();
      var serverPublicKey = result.Get<ServerPublicKey>();

      UserStore.Installation.ClientKeyPair = keyPairClient;
      UserStore.Installation.Id = id.Value;
      UserStore.Installation.Token = sessionToken.Value;
      UserStore.Installation.ServerPublicKey = SecurityUtils.CreatePublicKeyFromPublicKeyFormattedString(serverPublicKey.Value);
    }



    internal async Task<bool> IsDeviceValid(bool fastValidation)
    {
      var device = UserStore.Device;
      if (device.Id == 0)
        return false;

      if (fastValidation)
        return true;

      // get current device
      //device.Description=;
      //device.Status=;
      //device.Ip=;

      return true;
    }

    internal async Task<Id> RegisterDevice(string deviceDescription, List<string> permittedIps)
    {
      var deviceServerClient = Client.DeviceServer();
      var result = await deviceServerClient.Register(deviceDescription, UserStore.ApiKey);

      var id = result.Get<Model.Id>();

      UserStore.Device.Id = id.Value;

      return id;
    }






    /// <summary>
    /// Create a new session and its data in a SessionContext.
    /// </summary>
    internal async Task InitializeSessionContext()
    {
      var sessionServerClient = Client.SessionServer();

      var result = await sessionServerClient.Initialize(UserStore.ApiKey);

      var id = result.Get<Model.Id>();
      var token = result.Get<Model.Token>();

      UserStore.Session.Id = id.Value;
      UserStore.Session.UserId = GetUserId(result);
      UserStore.Session.Token = token.Value;
      UserStore.Session.ExpiryTime = DateTime.Now.AddSeconds(GetSessionTimeout(result));
    }

    private static int GetUserId(BunqResponse result)
    {
      var userPerson = result.Get<Model.UserPerson>();
      var userCompany = result.Get<Model.UserCompany>();
      var userApiKey = result.Get<Model.UserApiKey>();
      
      if (userCompany != null && userApiKey == null && userPerson == null)
      {
        //Debug.Assert(sessionServer.UserCompany.Id != null, ErrorSessionserverUsercompanyIdNull);
        return userCompany.Id;
      }
      else if (userPerson != null && userApiKey == null && userCompany == null)
      {
        //Debug.Assert(sessionServer.UserPerson.Id != null, ErrorsessionserverUserpersonIdNull);
        return userPerson.Id;
      }
      else if (userApiKey != null && userCompany == null && userPerson == null)
      {
        //Debug.Assert(sessionServer.UserApiKey.Id != null, ErrorSessionserverUserapikeyIdNull);
        return userApiKey.Id;
      }
      else
      {
        throw new BunqException("ErrorCouldNotDetermineUserId");//TODO message
      }
    }

    private static double GetSessionTimeout(BunqResponse result)
    {
      var userPerson = result.Get<Model.UserPerson>();
      var userCompany = result.Get<Model.UserCompany>();
      var userApiKey = result.Get<Model.UserApiKey>();

      if (userApiKey != null && userCompany == null && userPerson == null)
      {
        if (userApiKey.RequestedByUser.Usercompany != null)
          return userApiKey.RequestedByUser.Usercompany.SessionTimeout;

        if (userApiKey.RequestedByUser.Userperson != null)
          return userApiKey.RequestedByUser.Userperson.SessionTimeout;

        throw new BunqException("ErrorCouldNotDetermineSessionTimeout");
      }

      if (userCompany != null && userApiKey == null && userPerson == null)
        return userCompany.SessionTimeout;

      if (userPerson != null && userApiKey == null && userCompany == null)
        return userPerson.SessionTimeout;

      throw new BunqException("ErrorCouldNotDetermineSessionTimeout");
    }



    /// <summary>
    /// Closes the current session and opens a new one.
    /// </summary>
    public async Task ResetSession()
    {
      DropSessionContext();
      await InitializeSessionContext();
    }

    private void DropSessionContext()
    {
      UserStore.Session = null;
    }

    /// <summary>
    /// Closes the current session.
    /// </summary>
    public async Task CloseSession()
    {
      await DeleteSession();
      DropSessionContext();
    }

    private async Task DeleteSession()
    {
      var sessionServerClient = Client.SessionServer();

      await sessionServerClient.Delete(SESSION_ID_DUMMY);
    }

    /// <summary>
    /// Check if current time is too close to the saved session expiry time and reset session if needed.
    /// </summary>
    public async Task<bool> EnsureSessionActive()
    {
      if (IsSessionActive())
        return false;

      await ResetSession();
      return true;
    }

    public bool IsSessionActive()
    {
      if (string.IsNullOrWhiteSpace(UserStore.Session.Token))
        return false;

      var timeToExpiry = UserStore.Session.ExpiryTime.Subtract(DateTime.Now);
      var timeToExpiryMinimum = new TimeSpan(
        TIME_UNIT_COUNT_NONE,
        TIME_UNIT_COUNT_NONE,
        TIME_TO_SESSION_EXPIRY_MINIMUM_SECONDS
      );

      return timeToExpiry > timeToExpiryMinimum;
    }



  }
}
