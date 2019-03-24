using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("RequestResponseUpdate")]
  public class RequestResponseUpdate
  {
    /// <summary>
    /// The id of the created item
    /// </summary>
    [JsonProperty(PropertyName = "Id")]
    public BunqId Id { get; set; }

  }
}
