using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Lakerfield.BunqSdk;
using Lakerfield.BunqSdk.Context;
using Lakerfield.BunqSdk.Http;
using Lakerfield.BunqSdk.Model;
using Lakerfield.BunqSdk.Store;

namespace Playground
{
  class Program
  {
    static async Task Main(string[] args)
    {
      Console.WriteLine("Hello World of The Free!");

      var store = await BunqStore.Load();
      try
      {
        var userStore = store.GetUser(BunqEnvironment.Sandbox);
        var context = new BunqContext(userStore);

        await context.Setup(fastValidation: false);

        var response = await context.Api.Client.User().Get();

        var userPerson = response.Get<UserPerson>();
        Console.WriteLine($"Connect to {userPerson.FirstName} {userPerson.MiddleName} {userPerson.LastName} ({userPerson.DisplayName})");
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        throw;
      }
      finally
      {
        await store.Save();
      }

    }

  }
}
