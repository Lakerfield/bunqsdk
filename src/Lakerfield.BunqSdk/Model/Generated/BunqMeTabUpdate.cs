using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("BunqMeTabUpdate")]
  public class BunqMeTabUpdate
  {
    /// <summary>
    /// The id of the created item
    /// </summary>
    [JsonProperty(PropertyName = "Id")]
    public BunqId Id { get; set; }

  }
}
