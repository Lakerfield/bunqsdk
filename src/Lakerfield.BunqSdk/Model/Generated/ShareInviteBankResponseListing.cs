using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("ShareInviteBankResponseListing")]
  public class ShareInviteBankResponseListing
  {
    /// <summary>
    /// The id of the ShareInviteBankResponse.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the ShareInviteBankResponse creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the ShareInviteBankResponse last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The monetary account and user who created the share.
    /// </summary>
    [JsonProperty(PropertyName = "counter_alias")]
    public LabelMonetaryAccount CounterAlias { get; set; }

    /// <summary>
    /// The user who cancelled the share if it has been revoked or rejected.
    /// </summary>
    [JsonProperty(PropertyName = "user_alias_cancelled")]
    public LabelUser UserAliasCancelled { get; set; }

    /// <summary>
    /// The id of the monetary account the ACCEPTED share applies to. null otherwise.
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_id")]
    public int MonetaryAccountId { get; set; }

    /// <summary>
    /// The id of the draft share invite bank.
    /// </summary>
    [JsonProperty(PropertyName = "draft_share_invite_bank_id")]
    public int DraftShareInviteBankId { get; set; }

    /// <summary>
    /// The share details.
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
    /// The description of this share. It is basically the monetary account description.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

  }
}
