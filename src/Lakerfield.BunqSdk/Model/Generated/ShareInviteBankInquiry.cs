using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("ShareInviteBankInquiry")]
  public class ShareInviteBankInquiry
  {
    /// <summary>
    /// The label of the user to share with.
    /// </summary>
    [JsonProperty(PropertyName = "counter_user_alias")]
    public LabelUser CounterUserAlias { get; set; }

    /// <summary>
    /// The id of the draft share invite bank.
    /// </summary>
    [JsonProperty(PropertyName = "draft_share_invite_bank_id")]
    public int DraftShareInviteBankId { get; set; }

    /// <summary>
    /// The share details. Only one of these objects is returned.
    /// </summary>
    [JsonProperty(PropertyName = "share_detail")]
    public ShareDetail ShareDetail { get; set; }

    /// <summary>
    /// The status of the share. Can be PENDING, REVOKED (the user deletes the share inquiry before it's accepted), ACCEPTED, CANCELLED (the user deletes an active share) or CANCELLATION_PENDING, CANCELLATION_ACCEPTED, CANCELLATION_REJECTED (for canceling mutual connects)
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The share type, either STANDARD or MUTUAL.
    /// </summary>
    [JsonProperty(PropertyName = "share_type")]
    public string ShareType { get; set; }

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

    /// <summary>
    /// The label of the monetary account that's being shared.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public LabelMonetaryAccount Alias { get; set; }

    /// <summary>
    /// The user who created the share.
    /// </summary>
    [JsonProperty(PropertyName = "user_alias_created")]
    public LabelUser UserAliasCreated { get; set; }

    /// <summary>
    /// The user who revoked the share.
    /// </summary>
    [JsonProperty(PropertyName = "user_alias_revoked")]
    public LabelUser UserAliasRevoked { get; set; }

    /// <summary>
    /// The id of the monetary account the share applies to.
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_id")]
    public int MonetaryAccountId { get; set; }

    /// <summary>
    /// The id of the newly created share invite.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
