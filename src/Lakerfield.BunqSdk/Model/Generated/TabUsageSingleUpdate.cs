using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TabUsageSingleUpdate")]
  public class TabUsageSingleUpdate
  {
    /// <summary>
    /// The uuid of the modified TabUsageSingle.
    /// </summary>
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

  }
}
