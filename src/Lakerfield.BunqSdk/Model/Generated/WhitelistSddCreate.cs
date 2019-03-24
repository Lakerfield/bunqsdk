using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("WhitelistSddCreate")]
  public class WhitelistSddCreate
  {
    /// <summary>
    /// The id of the created item
    /// </summary>
    [JsonProperty(PropertyName = "Id")]
    public BunqId Id { get; set; }

  }
}
