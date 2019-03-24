using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("MonetaryAccountJointUpdate")]
  public class MonetaryAccountJointUpdate
  {
    /// <summary>
    /// The id of the created item
    /// </summary>
    [JsonProperty(PropertyName = "Id")]
    public BunqId Id { get; set; }

  }
}
