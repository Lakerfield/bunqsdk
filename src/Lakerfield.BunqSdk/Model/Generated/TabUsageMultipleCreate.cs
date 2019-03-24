using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TabUsageMultipleCreate")]
  public class TabUsageMultipleCreate
  {
    /// <summary>
    /// The uuid of the created TabUsageMultiple.
    /// </summary>
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

  }
}
