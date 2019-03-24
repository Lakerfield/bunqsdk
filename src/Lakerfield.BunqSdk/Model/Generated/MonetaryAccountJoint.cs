using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("MonetaryAccountJoint")]
  public class MonetaryAccountJoint
  {
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
    /// The maximum Amount the MonetaryAccountJoint can be 'in the red'. Must be 0 EUR or omitted.
    /// </summary>
    [JsonProperty(PropertyName = "overdraft_limit")]
    public Amount OverdraftLimit { get; set; }

    /// <summary>
    /// The Aliases to add to MonetaryAccountJoint. Must all be confirmed first. Can mostly be ignored.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public Pointer[] Alias { get; set; }

    /// <summary>
    /// The UUID of the Avatar of the MonetaryAccountJoint.
    /// </summary>
    [JsonProperty(PropertyName = "avatar_uuid")]
    public string AvatarUuid { get; set; }

    /// <summary>
    /// The status of the MonetaryAccountJoint. Ignored in POST requests (always set to ACTIVE) can be CANCELLED or PENDING_REOPEN in PUT requests to cancel (close) or reopen the MonetaryAccountJoint. When updating the status and/or sub_status no other fields can be updated in the same request (and vice versa).
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The sub-status of the MonetaryAccountJoint providing extra information regarding the status. Should be ignored for POST requests. In case of PUT requests with status CANCELLED it can only be REDEMPTION_VOLUNTARY, while with status PENDING_REOPEN it can only be NONE. When updating the status and/or sub_status no other fields can be updated in the same request (and vice versa).
    /// </summary>
    [JsonProperty(PropertyName = "sub_status")]
    public string SubStatus { get; set; }

    /// <summary>
    /// The reason for voluntarily cancelling (closing) the MonetaryAccountJoint, can only be OTHER. Should only be specified if updating the status to CANCELLED.
    /// </summary>
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// The optional free-form reason for voluntarily cancelling (closing) the MonetaryAccountJoint. Can be any user provided message. Should only be specified if updating the status to CANCELLED.
    /// </summary>
    [JsonProperty(PropertyName = "reason_description")]
    public string ReasonDescription { get; set; }

    /// <summary>
    /// The users the account will be joint with.
    /// </summary>
    [JsonProperty(PropertyName = "all_co_owner")]
    public CoOwner[] AllCoOwner { get; set; }

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
