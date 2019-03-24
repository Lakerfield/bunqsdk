using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("PermittedDevice")]
  public class PermittedDevice
  {
    /// <summary>
    /// The description of the device that may use the credential.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The IP address of the device that may use the credential.
    /// </summary>
    [JsonProperty(PropertyName = "ip")]
    public string Ip { get; set; }

  }
}
