using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("Id")]
  public class BunqId
  {
    /// <summary>
    /// An integer ID of an object. Unique per object type.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
