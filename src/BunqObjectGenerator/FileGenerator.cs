using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BunqObjectGenerator
{
  public class FileGenerator
  {
    public static Dictionary<string, string> ResponseObjectNames = new Dictionary<string, string>()
    {
      {"InstallationServerPublicKey", "ServerPublicKey"},
      {"InstallationToken", "Token"},
      {"BunqId", "Id"},
    };

    public DirectoryInfo TargetDirectory { get; }

    public FileGenerator(DirectoryInfo targetDirectory)
    {
      TargetDirectory = targetDirectory;
    }

    public async Task GenerateObject(JProperty schemaProperty)
    {
      var objectName = schemaProperty.Name;
      var bunqObjectName = GetBunqObjectName(objectName);
      var schema = (JObject)schemaProperty.Value;

      var schemaType = ((JValue)schema.GetValue("type")).Value.ToString();

      JProperty[] properties = new JProperty[0];
      switch (schemaType)
      {
        case "object":
          if (schema.TryGetValue("properties", out JToken propertiesToken))
            properties = ((JObject)propertiesToken).Properties().ToArray();
          break;

        case "array":
          //Error type
          break;

        default:
          return;
      }

      var file = new FileInfo(Path.Combine(TargetDirectory.FullName, $"{objectName}.cs"));
      if (file.Exists)
        file.Delete();

      using (var stream = file.OpenWrite())
      using (var writer = new StreamWriter(stream))
      {
        await writer.WriteLineAsync(@"using Newtonsoft.Json;");
        await writer.WriteLineAsync(@"");
        await writer.WriteLineAsync(@"namespace Lakerfield.BunqSdk.Model");
        await writer.WriteLineAsync(@"{");
        await writer.WriteLineAsync($"  [BunqObject(\"{bunqObjectName}\")]");
        await writer.WriteLineAsync($"  public class {objectName}");
        await writer.WriteLineAsync(@"  {");

        if (properties.Length == 0)
        {
            await writer.WriteLineAsync($"    // TODO: Empty class in definition");
            await writer.WriteLineAsync($"");
        }
        else
        {
          foreach (var property in properties)
          {
            var name = property.Name;
            var details = (JObject)property.Value;
            var pascalName = ConvertUnderscoreToPascalCase(name);
            if (objectName == pascalName)
              pascalName = "Value";
            var description = ((JValue)details.GetValue("description")).Value;
            var type = GetCSharpType(details);

            if (string.IsNullOrWhiteSpace(type))
            {
              await writer.WriteLineAsync($"    // TODO: Skipped property {name}");
              await writer.WriteLineAsync($"");

              continue;
            }

            await writer.WriteLineAsync($"    /// <summary>");
            await writer.WriteLineAsync($"    /// {description}");
            await writer.WriteLineAsync($"    /// </summary>");
            await writer.WriteLineAsync($"    [JsonProperty(PropertyName = \"{name}\")]");
            await writer.WriteLineAsync($"    public {type} {pascalName} {{ get; set; }}");
            await writer.WriteLineAsync($"");
          }
        }

        await writer.WriteLineAsync(@"  }");
        await writer.WriteLineAsync(@"}");
      }
    }

    private string GetBunqObjectName(string name)
    {
      if (ResponseObjectNames.TryGetValue(name, out var result))
        return result;
      return name;
    }

    private string GetCSharpType(JObject details)
    {
      var type = ((JValue)details.GetValue("type")).Value.ToString();
      switch (type)
      {
        case "string":
          return "string";

        case "integer":
          return "int";

        case "object":
          var objectRefValue = ((JValue)details.GetValue("$ref")).Value.ToString();
          if (objectRefValue.StartsWith("#/components/schemas/"))
            return objectRefValue.Replace("#/components/schemas/", "");
          return "";

        case "array":
          var arrayItems = (JObject)details.GetValue("items");
          if (arrayItems == null)
            return "";
          var arrayRef = arrayItems.GetValue("$ref");
          if (arrayRef == null)
          {
            var arrayType = arrayItems.GetValue("type");
            return $"{((JValue)arrayType).Value}[]";
          }
          var arrayRefValue = ((JValue)arrayRef).Value.ToString();
          if (arrayRefValue.StartsWith("#/components/schemas/"))
            return $"{arrayRefValue.Replace("#/components/schemas/", "")}[]";
          return "";

        case "boolean":
          return "bool";

        default:
          throw new ArgumentOutOfRangeException($"Unknown type {type}");
      }
    }

    private string ConvertUnderscoreToPascalCase(string input)
    {
      string[] words = input.Split('_');
      return string.Join("", words.Select(WordToPascalCase));
    }

    private string WordToPascalCase(string input)
    {
      return input.First().ToString().ToUpper() + input.Substring(1).ToLower();
    }

  }
}
