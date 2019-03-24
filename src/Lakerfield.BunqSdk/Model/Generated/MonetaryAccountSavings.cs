using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("MonetaryAccountSavings")]
  public class MonetaryAccountSavings
  {
    /// <summary>
    /// The currency of the MonetaryAccountSavings as an ISO 4217 formatted currency code.
    /// </summary>
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// The description of the MonetaryAccountSavings. Defaults to 'bunq account'.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The daily spending limit Amount of the MonetaryAccountSavings. Defaults to 1000 EUR. Currency must match the MonetaryAccountSavings's currency. Limited to 10000 EUR.
    /// </summary>
    [JsonProperty(PropertyName = "daily_limit")]
    public Amount DailyLimit { get; set; }

    /// <summary>
    /// The UUID of the Avatar of the MonetaryAccountSavings.
    /// </summary>
    [JsonProperty(PropertyName = "avatar_uuid")]
    public string AvatarUuid { get; set; }

    /// <summary>
    /// The status of the MonetaryAccountSavings. Ignored in POST requests (always set to ACTIVE) can be CANCELLED or PENDING_REOPEN in PUT requests to cancel (close) or reopen the MonetaryAccountSavings. When updating the status and/or sub_status no other fields can be updated in the same request (and vice versa).
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The sub-status of the MonetaryAccountSavings providing extra information regarding the status. Should be ignored for POST requests. In case of PUT requests with status CANCELLED it can only be REDEMPTION_VOLUNTARY, while with status PENDING_REOPEN it can only be NONE. When updating the status and/or sub_status no other fields can be updated in the same request (and vice versa).
    /// </summary>
    [JsonProperty(PropertyName = "sub_status")]
    public string SubStatus { get; set; }

    /// <summary>
    /// The reason for voluntarily cancelling (closing) the MonetaryAccountSavings, can only be OTHER. Should only be specified if updating the status to CANCELLED.
    /// </summary>
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// The optional free-form reason for voluntarily cancelling (closing) the MonetaryAccountSavings. Can be any user provided message. Should only be specified if updating the status to CANCELLED.
    /// </summary>
    [JsonProperty(PropertyName = "reason_description")]
    public string ReasonDescription { get; set; }

    /// <summary>
    /// The users the account will be joint with.
    /// </summary>
    [JsonProperty(PropertyName = "all_co_owner")]
    public CoOwner[] AllCoOwner { get; set; }

    /// <summary>
    /// The types of notifications that will result in a push notification or URL callback for this MonetaryAccountSavings.
    /// </summary>
    [JsonProperty(PropertyName = "notification_filters")]
    public NotificationFilter[] NotificationFilters { get; set; }

    /// <summary>
    /// The settings of the MonetaryAccountSavings.
    /// </summary>
    [JsonProperty(PropertyName = "setting")]
    public MonetaryAccountSetting Setting { get; set; }

    /// <summary>
    /// The Savings Goal set for this MonetaryAccountSavings.
    /// </summary>
    [JsonProperty(PropertyName = "savings_goal")]
    public Amount SavingsGoal { get; set; }

  }
}
