using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
      return JsonConvert.DeserializeObject<BunqStore>(data);
    }

    public Task Save()
    {
      var data = JsonConvert.SerializeObject(this, Formatting.Indented);
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
    public BunqEnvironment Environment { get; set; }
    public string ApiKey { get; set; }


  }


}
