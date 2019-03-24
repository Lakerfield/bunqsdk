using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("DeviceServerCreate")]
  public class DeviceServerCreate
  {
    /// <summary>
    /// The id of the DeviceServer as created on the server.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
