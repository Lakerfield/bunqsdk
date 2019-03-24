using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("NotificationFilter")]
  public class NotificationFilter
  {
    /// <summary>
    /// The delivery method via which notifications that match this notification filter will be delivered. Possible choices are PUSH for delivery via push notification and URL for delivery via URL callback.
    /// </summary>
    [JsonProperty(PropertyName = "notification_delivery_method")]
    public string NotificationDeliveryMethod { get; set; }

    /// <summary>
    /// The target of notifications that match this notification filter. For URL notification filters this is the URL to which the callback will be made. For PUSH notifications filters this should always be null.
    /// </summary>
    [JsonProperty(PropertyName = "notification_target")]
    public string NotificationTarget { get; set; }

    /// <summary>
    /// The notification category that will match this notification filter. Possible choices are BILLING, CARD_TRANSACTION_FAILED, CARD_TRANSACTION_SUCCESSFUL, CHAT, DRAFT_PAYMENT, IDEAL, SOFORT, MONETARY_ACCOUNT_PROFILE, MUTATION, PAYMENT, PROMOTION, REQUEST, SCHEDULE_RESULT, SCHEDULE_STATUS, SHARE, SUPPORT, TAB_RESULT, USER_APPROVAL.
    /// </summary>
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

  }
}
