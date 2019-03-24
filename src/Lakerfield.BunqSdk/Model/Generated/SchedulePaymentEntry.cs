using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("SchedulePaymentEntry")]
  public class SchedulePaymentEntry
  {
    /// <summary>
    /// The Amount transferred by the Payment. Will be negative for outgoing Payments and positive for incoming Payments (relative to the MonetaryAccount indicated by monetary_account_id).
    /// </summary>
    [JsonProperty(PropertyName = "amount")]
    public Amount Amount { get; set; }

    /// <summary>
    /// The LabelMonetaryAccount containing the public information of the other (counterparty) side of the Payment.
    /// </summary>
    [JsonProperty(PropertyName = "counterparty_alias")]
    public LabelMonetaryAccount CounterpartyAlias { get; set; }

    /// <summary>
    /// The description for the Payment. Maximum 140 characters for Payments to external IBANs, 9000 characters for Payments to only other bunq MonetaryAccounts.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The Attachments attached to the Payment.
    /// </summary>
    [JsonProperty(PropertyName = "attachment")]
    public AttachmentMonetaryAccountPayment[] Attachment { get; set; }

    /// <summary>
    /// Optional data included with the Payment specific to the merchant.
    /// </summary>
    [JsonProperty(PropertyName = "merchant_reference")]
    public string MerchantReference { get; set; }

    /// <summary>
    /// Whether or not sending a bunq.to payment is allowed.
    /// </summary>
    [JsonProperty(PropertyName = "allow_bunqto")]
    public bool AllowBunqto { get; set; }

    /// <summary>
    /// The LabelMonetaryAccount containing the public information of 'this' (party) side of the Payment.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public LabelMonetaryAccount Alias { get; set; }

  }
}
