using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("MonetaryAccountJointListing")]
  public class MonetaryAccountJointListing
  {
    /// <summary>
    /// The id of the MonetaryAccountJoint.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the MonetaryAccountJoint's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the MonetaryAccountJoint's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The Avatar of the MonetaryAccountJoint.
    /// </summary>
    [JsonProperty(PropertyName = "avatar")]
    public Avatar Avatar { get; set; }

    /// <summary>
    /// The currency of the MonetaryAccountJoint as an ISO 4217 formatted currency code.
    /// </summary>
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// The description of the MonetaryAccountJoint. Defaults to 'bunq account'.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The daily spending limit Amount of the MonetaryAccountJoint. Defaults to 1000 EUR. Currency must match the MonetaryAccountJoint's currency. Limited to 10000 EUR.
    /// </summary>
    [JsonProperty(PropertyName = "daily_limit")]
    public Amount DailyLimit { get; set; }

    /// <summary>
    /// Total Amount of money spent today. Timezone aware.
    /// </summary>
    [JsonProperty(PropertyName = "daily_spent")]
    public Amount DailySpent { get; set; }

    /// <summary>
    /// The maximum Amount the MonetaryAccountJoint can be 'in the red'.
    /// </summary>
    [JsonProperty(PropertyName = "overdraft_limit")]
    public Amount OverdraftLimit { get; set; }

    /// <summary>
    /// The current balance Amount of the MonetaryAccountJoint.
    /// </summary>
    [JsonProperty(PropertyName = "balance")]
    public Amount Balance { get; set; }

    /// <summary>
    /// The Aliases for the MonetaryAccountJoint.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public Pointer[] Alias { get; set; }

    /// <summary>
    /// The MonetaryAccountJoint's public UUID.
    /// </summary>
    [JsonProperty(PropertyName = "public_uuid")]
    public string PublicUuid { get; set; }

    /// <summary>
    /// The status of the MonetaryAccountJoint. Can be: ACTIVE, BLOCKED, CANCELLED or PENDING_REOPEN
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The sub-status of the MonetaryAccountJoint providing extra information regarding the status. Will be NONE for ACTIVE or PENDING_REOPEN, COMPLETELY or ONLY_ACCEPTING_INCOMING for BLOCKED and REDEMPTION_INVOLUNTARY, REDEMPTION_VOLUNTARY or PERMANENT for CANCELLED.
    /// </summary>
    [JsonProperty(PropertyName = "sub_status")]
    public string SubStatus { get; set; }

    /// <summary>
    /// The reason for voluntarily cancelling (closing) the MonetaryAccountJoint, can only be OTHER.
    /// </summary>
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// The optional free-form reason for voluntarily cancelling (closing) the MonetaryAccountJoint. Can be any user provided message.
    /// </summary>
    [JsonProperty(PropertyName = "reason_description")]
    public string ReasonDescription { get; set; }

    /// <summary>
    /// The users the account will be joint with.
    /// </summary>
    [JsonProperty(PropertyName = "all_co_owner")]
    public CoOwner[] AllCoOwner { get; set; }

    /// <summary>
    /// The id of the User who owns the MonetaryAccountJoint.
    /// </summary>
    [JsonProperty(PropertyName = "user_id")]
    public int UserId { get; set; }

    /// <summary>
    /// The profile of the account.
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_profile")]
    public MonetaryAccountProfile MonetaryAccountProfile { get; set; }

    /// <summary>
    /// The types of notifications that will result in a push notification or URL callback for this MonetaryAccountJoint.
    /// </summary>
    [JsonProperty(PropertyName = "notification_filters")]
    public NotificationFilter[] NotificationFilters { get; set; }

    /// <summary>
    /// The settings of the MonetaryAccountJoint.
    /// </summary>
    [JsonProperty(PropertyName = "setting")]
    public MonetaryAccountSetting Setting { get; set; }

  }
}
