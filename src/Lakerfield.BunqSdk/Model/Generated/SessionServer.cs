using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("SessionServer")]
  public class SessionServer
  {
    /// <summary>
    /// The API key of the user you want to login. If your API key has not been used before, it will be bound to the ip address of this DeviceServer.
    /// </summary>
    [JsonProperty(PropertyName = "secret")]
    public string Secret { get; set; }

  }
}
