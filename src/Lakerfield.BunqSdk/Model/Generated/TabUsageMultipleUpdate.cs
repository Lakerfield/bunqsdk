using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TabUsageMultipleUpdate")]
  public class TabUsageMultipleUpdate
  {
    /// <summary>
    /// The uuid of the modified TabUsageMultiple.
    /// </summary>
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

  }
}
