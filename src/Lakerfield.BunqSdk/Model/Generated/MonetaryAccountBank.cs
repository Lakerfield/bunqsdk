using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("MonetaryAccountBank")]
  public class MonetaryAccountBank
  {
    /// <summary>
    /// The currency of the MonetaryAccountBank as an ISO 4217 formatted currency code.
    /// </summary>
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// The description of the MonetaryAccountBank. Defaults to 'bunq account'.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The daily spending limit Amount of the MonetaryAccountBank. Defaults to 1000 EUR. Currency must match the MonetaryAccountBank's currency. Limited to 10000 EUR.
    /// </summary>
    [JsonProperty(PropertyName = "daily_limit")]
    public Amount DailyLimit { get; set; }

    /// <summary>
    /// The UUID of the Avatar of the MonetaryAccountBank.
    /// </summary>
    [JsonProperty(PropertyName = "avatar_uuid")]
    public string AvatarUuid { get; set; }

    /// <summary>
    /// The status of the MonetaryAccountBank. Ignored in POST requests (always set to ACTIVE) can be CANCELLED or PENDING_REOPEN in PUT requests to cancel (close) or reopen the MonetaryAccountBank. When updating the status and/or sub_status no other fields can be updated in the same request (and vice versa).
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The sub-status of the MonetaryAccountBank providing extra information regarding the status. Should be ignored for POST requests. In case of PUT requests with status CANCELLED it can only be REDEMPTION_VOLUNTARY, while with status PENDING_REOPEN it can only be NONE. When updating the status and/or sub_status no other fields can be updated in the same request (and vice versa).
    /// </summary>
    [JsonProperty(PropertyName = "sub_status")]
    public string SubStatus { get; set; }

    /// <summary>
    /// The reason for voluntarily cancelling (closing) the MonetaryAccountBank, can only be OTHER. Should only be specified if updating the status to CANCELLED.
    /// </summary>
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// The optional free-form reason for voluntarily cancelling (closing) the MonetaryAccountBank. Can be any user provided message. Should only be specified if updating the status to CANCELLED.
    /// </summary>
    [JsonProperty(PropertyName = "reason_description")]
    public string ReasonDescription { get; set; }

    /// <summary>
    /// The types of notifications that will result in a push notification or URL callback for this MonetaryAccountBank.
    /// </summary>
    [JsonProperty(PropertyName = "notification_filters")]
    public NotificationFilter[] NotificationFilters { get; set; }

    /// <summary>
    /// The settings of the MonetaryAccountBank.
    /// </summary>
    [JsonProperty(PropertyName = "setting")]
    public MonetaryAccountSetting Setting { get; set; }

  }
}
