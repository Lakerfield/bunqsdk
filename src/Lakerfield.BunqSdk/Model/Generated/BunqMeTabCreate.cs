using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("BunqMeTabCreate")]
  public class BunqMeTabCreate
  {
    /// <summary>
    /// The id of the created bunq.me.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
