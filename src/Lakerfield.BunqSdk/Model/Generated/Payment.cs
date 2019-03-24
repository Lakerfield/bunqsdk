using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("Payment")]
  public class Payment
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
    /// The id of the created Payment.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp when the Payment was done.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp when the Payment was last updated (will be updated when chat messages are received).
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The id of the MonetaryAccount the Payment was made to or from (depending on whether this is an incoming or outgoing Payment).
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_id")]
    public int MonetaryAccountId { get; set; }

    /// <summary>
    /// The LabelMonetaryAccount containing the public information of 'this' (party) side of the Payment.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public LabelMonetaryAccount Alias { get; set; }

    /// <summary>
    /// The type of Payment, can be BUNQ, EBA_SCT, EBA_SDD, IDEAL, SWIFT or FIS (card).
    /// </summary>
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The sub-type of the Payment, can be PAYMENT, WITHDRAWAL, REVERSAL, REQUEST, BILLING, SCT, SDD or NLO.
    /// </summary>
    [JsonProperty(PropertyName = "sub_type")]
    public string SubType { get; set; }

    /// <summary>
    /// The status of the bunq.to payment.
    /// </summary>
    [JsonProperty(PropertyName = "bunqto_status")]
    public string BunqtoStatus { get; set; }

    /// <summary>
    /// The sub status of the bunq.to payment.
    /// </summary>
    [JsonProperty(PropertyName = "bunqto_sub_status")]
    public string BunqtoSubStatus { get; set; }

    /// <summary>
    /// The status of the bunq.to payment.
    /// </summary>
    [JsonProperty(PropertyName = "bunqto_share_url")]
    public string BunqtoShareUrl { get; set; }

    /// <summary>
    /// When bunq.to payment is about to expire.
    /// </summary>
    [JsonProperty(PropertyName = "bunqto_expiry")]
    public string BunqtoExpiry { get; set; }

    /// <summary>
    /// The timestamp of when the bunq.to payment was responded to.
    /// </summary>
    [JsonProperty(PropertyName = "bunqto_time_responded")]
    public string BunqtoTimeResponded { get; set; }

    /// <summary>
    /// The id of the PaymentBatch if this Payment was part of one.
    /// </summary>
    [JsonProperty(PropertyName = "batch_id")]
    public int BatchId { get; set; }

    /// <summary>
    /// The id of the JobScheduled if the Payment was scheduled.
    /// </summary>
    [JsonProperty(PropertyName = "scheduled_id")]
    public int ScheduledId { get; set; }

    /// <summary>
    /// A shipping Address provided with the Payment, currently unused.
    /// </summary>
    [JsonProperty(PropertyName = "address_shipping")]
    public Address AddressShipping { get; set; }

    /// <summary>
    /// A billing Address provided with the Payment, currently unused.
    /// </summary>
    [JsonProperty(PropertyName = "address_billing")]
    public Address AddressBilling { get; set; }

    /// <summary>
    /// The Geolocation where the Payment was done from.
    /// </summary>
    [JsonProperty(PropertyName = "geolocation")]
    public Geolocation Geolocation { get; set; }

    /// <summary>
    /// Whether or not chat messages are allowed.
    /// </summary>
    [JsonProperty(PropertyName = "allow_chat")]
    public bool AllowChat { get; set; }

    /// <summary>
    /// The reference to the object used for split the bill. Can be RequestInquiry or RequestInquiryBatch
    /// </summary>
    [JsonProperty(PropertyName = "request_reference_split_the_bill")]
    public RequestInquiryReference[] RequestReferenceSplitTheBill { get; set; }

    /// <summary>
    /// The new balance of the monetary account after the mutation.
    /// </summary>
    [JsonProperty(PropertyName = "balance_after_mutation")]
    public Amount BalanceAfterMutation { get; set; }

  }
}
