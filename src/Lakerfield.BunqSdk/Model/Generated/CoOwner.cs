using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CoOwner")]
  public class CoOwner
  {
    /// <summary>
    /// The Alias of the co-owner.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public LabelUser Alias { get; set; }

    /// <summary>
    /// Can be: ACCEPTED, REJECTED, PENDING or REVOKED
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

  }
}
