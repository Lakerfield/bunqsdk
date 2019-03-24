using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("PermittedIpCreate")]
  public class PermittedIpCreate
  {
    /// <summary>
    /// The id of the created item
    /// </summary>
    [JsonProperty(PropertyName = "Id")]
    public BunqId Id { get; set; }

  }
}
