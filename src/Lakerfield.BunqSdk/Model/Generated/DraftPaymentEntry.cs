using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("DraftPaymentEntry")]
  public class DraftPaymentEntry
  {
    /// <summary>
    /// The amount of the payment.
    /// </summary>
    [JsonProperty(PropertyName = "amount")]
    public Amount Amount { get; set; }

    /// <summary>
    /// The LabelMonetaryAccount containing the public information of the other (counterparty) side of the DraftPayment.
    /// </summary>
    [JsonProperty(PropertyName = "counterparty_alias")]
    public LabelMonetaryAccount CounterpartyAlias { get; set; }

    /// <summary>
    /// The description for the DraftPayment. Maximum 140 characters for DraftPayments to external IBANs, 9000 characters for DraftPayments to only other bunq MonetaryAccounts.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Optional data to be included with the Payment specific to the merchant.
    /// </summary>
    [JsonProperty(PropertyName = "merchant_reference")]
    public string MerchantReference { get; set; }

    /// <summary>
    /// The Attachments attached to the DraftPayment.
    /// </summary>
    [JsonProperty(PropertyName = "attachment")]
    public AttachmentMonetaryAccountPayment[] Attachment { get; set; }

    /// <summary>
    /// The id of the draft payment entry.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The LabelMonetaryAccount containing the public information of 'this' (party) side of the DraftPayment.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public LabelMonetaryAccount Alias { get; set; }

    /// <summary>
    /// The type of the draft payment entry.
    /// </summary>
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

  }
}
