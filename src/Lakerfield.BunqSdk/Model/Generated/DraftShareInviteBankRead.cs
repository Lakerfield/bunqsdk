using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("DraftShareInviteBankRead")]
  public class DraftShareInviteBankRead
  {
    /// <summary>
    /// The user who created the draft share invite.
    /// </summary>
    [JsonProperty(PropertyName = "user_alias_created")]
    public LabelUser UserAliasCreated { get; set; }

    /// <summary>
    /// The status of the draft share invite. Can be USED, CANCELLED and PENDING.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The moment when this draft share invite expires.
    /// </summary>
    [JsonProperty(PropertyName = "expiration")]
    public string Expiration { get; set; }

    /// <summary>
    /// The id of the share invite bank response this draft share belongs to.
    /// </summary>
    [JsonProperty(PropertyName = "share_invite_bank_response_id")]
    public int ShareInviteBankResponseId { get; set; }

    /// <summary>
    /// The URL redirecting user to the draft share invite in the app. Only works on mobile devices.
    /// </summary>
    [JsonProperty(PropertyName = "draft_share_url")]
    public string DraftShareUrl { get; set; }

    /// <summary>
    /// The draft share invite details.
    /// </summary>
    [JsonProperty(PropertyName = "draft_share_settings")]
    public DraftShareInviteEntry DraftShareSettings { get; set; }

    /// <summary>
    /// The id of the newly created draft share invite.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
