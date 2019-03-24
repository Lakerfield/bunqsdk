using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("DraftShareInviteBank")]
  public class DraftShareInviteBank
  {
    /// <summary>
    /// The status of the draft share invite. Can be CANCELLED (the user cancels the draft share before it's used).
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The moment when this draft share invite expires.
    /// </summary>
    [JsonProperty(PropertyName = "expiration")]
    public string Expiration { get; set; }

    /// <summary>
    /// The draft share invite details.
    /// </summary>
    [JsonProperty(PropertyName = "draft_share_settings")]
    public DraftShareInviteEntry DraftShareSettings { get; set; }

  }
}
