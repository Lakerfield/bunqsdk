using System;
using System.Threading.Tasks;
using Lakerfield.BunqSdk.Context;

namespace Playground
{
  class Program
  {
    static async Task Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      var context = new BunqContext(ApiEnvironmentType.SANDBOX);


      await context.Setup();


    }
  }
}
