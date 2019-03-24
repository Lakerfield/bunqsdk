using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("DeviceServerListing")]
  public class DeviceServerListing
  {
    /// <summary>
    /// The id of the DeviceServer as created on the server.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the DeviceServer's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the DeviceServer's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The description of the DeviceServer.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The ip address which was used to create the DeviceServer.
    /// </summary>
    [JsonProperty(PropertyName = "ip")]
    public string Ip { get; set; }

    /// <summary>
    /// The status of the DeviceServer. Can be ACTIVE, BLOCKED, NEEDS_CONFIRMATION or OBSOLETE.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

  }
}
