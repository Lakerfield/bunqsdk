using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Lakerfield.BunqSdk;
using Lakerfield.BunqSdk.Context;
using Lakerfield.BunqSdk.Json;
using Lakerfield.BunqSdk.Model;
using Lakerfield.BunqSdk.Store;
using Newtonsoft.Json.Linq;

namespace Playground
{
  class Program
  {
    static async Task Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      var store = await BunqStore.Load();
      try
      {
        var userStore = store.GetUser(BunqEnvironment.Sandbox);
        var context = new BunqContext(userStore);

        await context.Setup();
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
