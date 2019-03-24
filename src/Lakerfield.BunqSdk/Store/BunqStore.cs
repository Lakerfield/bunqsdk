using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Lakerfield.BunqSdk.Json;

namespace Lakerfield.BunqSdk.Store
{
  public class BunqStore
  {
    public const string FILENAME = "store.json";

    public static async Task<BunqStore> Load()
    {
      var file = new FileInfo(FILENAME);
      if (!file.Exists)
        return new BunqStore();

      var data = await File.ReadAllTextAsync(file.FullName);
      return BunqJsonConvert.DeserializeObject<BunqStore>(data);
    }

    public Task Save()
    {
      var data = BunqJsonConvert.SerializeObject(this, Formatting.Indented);
      return File.WriteAllTextAsync(FILENAME, data);
    }


    private List<User> _users;
    public List<User> Users
    {
      get => _users ?? (_users = new List<User>());
      set => _users = value;
    }


    public User GetUser(BunqEnvironment environment)
    {
      var user = Users.FirstOrDefault(u => u.Environment == environment);

      if (user == null)
      {
        user = new User();
        Users.Add(user);
      }

      return user;
    }
  }

  public class User
  {
    [JsonConverter(typeof(StringEnumConverter))]
    public BunqEnvironment Environment { get; set; }

    public string ApiKey { get; set; }

    private UserInstallation _installation;
    public UserInstallation Installation
    {
      get { return _installation ?? (_installation = new UserInstallation()); }
      set { _installation = value; }
    }

    private UserDevice _device;
    public UserDevice Device
    {
      get { return _device ?? (_device = new UserDevice()); }
      set { _device = value; }
    }

    private UserSession _session;
    public UserSession Session
    {
      get { return _session ?? (_session = new UserSession()); }
      set { _session = value; }
    }
  }

  public class UserInstallation
  {
    public int Id { get; set; }
    public string Token { get; set; }
    public RSA ClientKeyPair { get; set; }
    public RSA ServerPublicKey { get; set; }
  }

  public class UserDevice
  {
    public int Id { get; set; }
    public string Description { get; set; }
    public string Ip { get; set; }
    public string Status { get; set; }
  }

  public class UserSession
  {
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Token { get; set; }
    public DateTime ExpiryTime { get; set; }
  }


}
