using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("DraftShareInviteEntry")]
  public class DraftShareInviteEntry
  {
    /// <summary>
    /// The share details. Only one of these objects is returned.
    /// </summary>
    [JsonProperty(PropertyName = "share_detail")]
    public ShareDetail ShareDetail { get; set; }

    /// <summary>
    /// The start date of this share.
    /// </summary>
    [JsonProperty(PropertyName = "start_date")]
    public string StartDate { get; set; }

    /// <summary>
    /// The expiration date of this share.
    /// </summary>
    [JsonProperty(PropertyName = "end_date")]
    public string EndDate { get; set; }

  }
}
