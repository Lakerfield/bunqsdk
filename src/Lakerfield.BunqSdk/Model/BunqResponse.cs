using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Lakerfield.BunqSdk.Model
{
  public class BunqResponse
  {
    public Dictionary<string, string> Headers { get; }
    private readonly JArray _array;

    public BunqResponse(JArray array, Dictionary<string, string> headers = null)
    {
      Headers = headers;
      _array = array;
    }

    public T Get<T>()
    {
      var attribute = typeof(T).GetCustomAttribute<BunqObjectAttribute>();
      if (attribute == null)
        throw new Exception("Cannot find BunqObjectAttribute");

      foreach (var token in _array)
      {
        if (token.Type != JTokenType.Object)
          continue;

        var response = (JObject)token;
        if (!response.TryGetValue(attribute.Name, out var result))
          continue;

        return result.ToObject<T>();
      }

      return default(T);
    }

  }


  [BunqObject("ApiKey")]
  public class ApiKey
  {
    [JsonProperty(PropertyName = "api_key")]
    public string Value { get; set; }
  }

  [BunqObject("ClientPublicKey")]
  public class ClientPublicKey
  {
    [JsonProperty(PropertyName = "client_public_key")]
    public string Value { get; set; }
  }

  [BunqObject("Id")]
  public class Id
  {
    [JsonProperty(PropertyName = "id")]
    public int Value { get; set; }
  }

  [BunqObject("Token")]
  public class Token
  {
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    [JsonProperty(PropertyName = "created")]
    public DateTime Created { get; set; }

    [JsonProperty(PropertyName = "updated")]
    public DateTime Updated { get; set; }

    [JsonProperty(PropertyName = "token")]
    public string Value { get; set; }
  }

  [BunqObject("ServerPublicKey")]
  public class ServerPublicKey
  {
    [JsonProperty(PropertyName = "server_public_key")]
    public string Value { get; set; }
  }

  [BunqObject("UserPerson")]
  public class UserPerson
  {
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    [JsonProperty(PropertyName = "created")]
    public DateTime Created { get; set; }

    [JsonProperty(PropertyName = "updated")]
    public DateTime Updated { get; set; }

    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    [JsonProperty(PropertyName = "public_uuid")]
    public string PublicUuid { get; set; }

    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

  }


}
