using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("DeviceServer")]
  public class DeviceServer
  {
    /// <summary>
    /// The description of the DeviceServer. This is only for your own reference when reading the DeviceServer again.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The API key. You can request an API key in the bunq app.
    /// </summary>
    [JsonProperty(PropertyName = "secret")]
    public string Secret { get; set; }

    /// <summary>
    /// An array of IPs (v4 or v6) this DeviceServer will be able to do calls from. These will be linked to the API key.
    /// </summary>
    [JsonProperty(PropertyName = "permitted_ips")]
    public string[] PermittedIps { get; set; }

  }
}
