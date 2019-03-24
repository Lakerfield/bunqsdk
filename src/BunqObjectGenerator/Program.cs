using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BunqObjectGenerator
{
  class Program
  {
    static async Task Main(string[] args)
    {
      try
      {
        Console.WriteLine("Hello World!");

        var client = new HttpClient();

        var swaggerJson = await client.GetStringAsync(@"https://raw.githubusercontent.com/bunq/doc/master/swagger.json");

        var rootObject = JsonConvert.DeserializeObject<JObject>(swaggerJson);

        var components = (JObject)rootObject.GetValue("components");
        var schemas = (JObject)components.GetValue("schemas");


        var generator = new FileGenerator(new DirectoryInfo("../../../../Lakerfield.BunqSdk/Model/Generated"));

        foreach (var schemaProperty in schemas.Properties())
        {
          Console.WriteLine($"{schemaProperty.Name}");
          await generator.GenerateObject(schemaProperty);
        }

      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        throw;
      }
#if DEBUG
      Console.ReadKey();
#endif
    }
  }
}
