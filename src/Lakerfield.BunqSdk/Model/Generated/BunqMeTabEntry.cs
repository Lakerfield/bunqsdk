using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("BunqMeTabEntry")]
  public class BunqMeTabEntry
  {
    /// <summary>
    /// The requested Amount.
    /// </summary>
    [JsonProperty(PropertyName = "amount_inquired")]
    public Amount AmountInquired { get; set; }

    /// <summary>
    /// The description for the bunq.me. Maximum 9000 characters.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The URL which the user is sent to when a payment is completed.
    /// </summary>
    [JsonProperty(PropertyName = "redirect_url")]
    public string RedirectUrl { get; set; }

    /// <summary>
    /// The uuid of the bunq.me.
    /// </summary>
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// The LabelMonetaryAccount with the public information of the User and the MonetaryAccount that created the bunq.me link.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public LabelMonetaryAccount Alias { get; set; }

    /// <summary>
    /// The status of the bunq.me. Can be WAITING_FOR_PAYMENT, CANCELLED or EXPIRED.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// List of available merchants.
    /// </summary>
    [JsonProperty(PropertyName = "merchant_available")]
    public BunqMeMerchantAvailable[] MerchantAvailable { get; set; }

  }
}
