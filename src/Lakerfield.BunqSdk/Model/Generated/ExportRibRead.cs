using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("ExportRibRead")]
  public class ExportRibRead
  {
    /// <summary>
    /// The id of the rib as created on the server.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the RIB's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the RIB's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

  }
}
