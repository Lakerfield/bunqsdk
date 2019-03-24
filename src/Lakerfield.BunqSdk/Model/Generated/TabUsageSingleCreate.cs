using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TabUsageSingleCreate")]
  public class TabUsageSingleCreate
  {
    /// <summary>
    /// The uuid of the created TabUsageSingle.
    /// </summary>
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

  }
}
