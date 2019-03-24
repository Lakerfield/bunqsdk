using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("DraftShareInviteApiKey")]
  public class DraftShareInviteApiKey
  {
    /// <summary>
    /// The status of the draft share invite. Can be CANCELLED (the user cancels the draft share before it's used).
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The sub-status of the draft share invite. Can be NONE, ACCEPTED or REJECTED.
    /// </summary>
    [JsonProperty(PropertyName = "sub_status")]
    public string SubStatus { get; set; }

    /// <summary>
    /// The moment when this draft share invite expires.
    /// </summary>
    [JsonProperty(PropertyName = "expiration")]
    public string Expiration { get; set; }

  }
}
