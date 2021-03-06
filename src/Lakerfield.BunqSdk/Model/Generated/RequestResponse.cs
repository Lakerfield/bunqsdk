using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("RequestResponse")]
  public class RequestResponse
  {
    /// <summary>
    /// The Amount the RequestResponse was accepted with.
    /// </summary>
    [JsonProperty(PropertyName = "amount_responded")]
    public Amount AmountResponded { get; set; }

    /// <summary>
    /// The status of the RequestResponse. Can be ACCEPTED, PENDING, REJECTED, REFUND_REQUESTED, REFUNDED or REVOKED.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The shipping address provided by the accepting user if an address was requested.
    /// </summary>
    [JsonProperty(PropertyName = "address_shipping")]
    public Address AddressShipping { get; set; }

    /// <summary>
    /// The billing address provided by the accepting user if an address was requested.
    /// </summary>
    [JsonProperty(PropertyName = "address_billing")]
    public Address AddressBilling { get; set; }

    /// <summary>
    /// The id of the Request Response.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp when the Request Response was created.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp when the Request Response was last updated (will be updated when chat messages are received).
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The timestamp of when the RequestResponse was responded to.
    /// </summary>
    [JsonProperty(PropertyName = "time_responded")]
    public string TimeResponded { get; set; }

    /// <summary>
    /// The timestamp of when the RequestResponse expired or will expire.
    /// </summary>
    [JsonProperty(PropertyName = "time_expiry")]
    public string TimeExpiry { get; set; }

    /// <summary>
    /// The timestamp of when a refund request for the RequestResponse was claimed.
    /// </summary>
    [JsonProperty(PropertyName = "time_refund_requested")]
    public string TimeRefundRequested { get; set; }

    /// <summary>
    /// The timestamp of when the RequestResponse was refunded.
    /// </summary>
    [JsonProperty(PropertyName = "time_refunded")]
    public string TimeRefunded { get; set; }

    /// <summary>
    /// The label of the user that requested the refund.
    /// </summary>
    [JsonProperty(PropertyName = "user_refund_requested")]
    public LabelUser UserRefundRequested { get; set; }

    /// <summary>
    /// The id of the MonetaryAccount the RequestResponse was received on.
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_id")]
    public int MonetaryAccountId { get; set; }

    /// <summary>
    /// The requested Amount.
    /// </summary>
    [JsonProperty(PropertyName = "amount_inquired")]
    public Amount AmountInquired { get; set; }

    /// <summary>
    /// The description for the RequestResponse provided by the requesting party. Maximum 9000 characters.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The LabelMonetaryAccount with the public information of the MonetaryAccount this RequestResponse was received on.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public LabelMonetaryAccount Alias { get; set; }

    /// <summary>
    /// The LabelMonetaryAccount with the public information of the MonetaryAccount that is requesting money with this RequestResponse.
    /// </summary>
    [JsonProperty(PropertyName = "counterparty_alias")]
    public LabelMonetaryAccount CounterpartyAlias { get; set; }

    /// <summary>
    /// The Attachments attached to the RequestResponse.
    /// </summary>
    [JsonProperty(PropertyName = "attachment")]
    public Attachment[] Attachment { get; set; }

    /// <summary>
    /// The minimum age the user accepting the RequestResponse must have.
    /// </summary>
    [JsonProperty(PropertyName = "minimum_age")]
    public int MinimumAge { get; set; }

    /// <summary>
    /// Whether or not an address must be provided on accept.
    /// </summary>
    [JsonProperty(PropertyName = "require_address")]
    public string RequireAddress { get; set; }

    /// <summary>
    /// The Geolocation where the RequestResponse was created.
    /// </summary>
    [JsonProperty(PropertyName = "geolocation")]
    public Geolocation Geolocation { get; set; }

    /// <summary>
    /// The type of the RequestInquiry. Can be DIRECT_DEBIT, DIRECT_DEBIT_B2B, IDEAL, SOFORT or INTERNAL.
    /// </summary>
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The subtype of the RequestInquiry. Can be ONCE or RECURRING for DIRECT_DEBIT RequestInquiries and NONE for all other.
    /// </summary>
    [JsonProperty(PropertyName = "sub_type")]
    public string SubType { get; set; }

    /// <summary>
    /// The URL which the user is sent to after accepting or rejecting the Request.
    /// </summary>
    [JsonProperty(PropertyName = "redirect_url")]
    public string RedirectUrl { get; set; }

    /// <summary>
    /// Whether or not chat messages are allowed.
    /// </summary>
    [JsonProperty(PropertyName = "allow_chat")]
    public bool AllowChat { get; set; }

    /// <summary>
    /// The credit scheme id provided by the counterparty for DIRECT_DEBIT inquiries.
    /// </summary>
    [JsonProperty(PropertyName = "credit_scheme_identifier")]
    public string CreditSchemeIdentifier { get; set; }

    /// <summary>
    /// The mandate id provided by the counterparty for DIRECT_DEBIT inquiries.
    /// </summary>
    [JsonProperty(PropertyName = "mandate_identifier")]
    public string MandateIdentifier { get; set; }

    /// <summary>
    /// The whitelist id for this action or null.
    /// </summary>
    [JsonProperty(PropertyName = "eligible_whitelist_id")]
    public int EligibleWhitelistId { get; set; }

    /// <summary>
    /// The reference to the object used for split the bill. Can be RequestInquiry or RequestInquiryBatch
    /// </summary>
    [JsonProperty(PropertyName = "request_reference_split_the_bill")]
    public RequestInquiryReference[] RequestReferenceSplitTheBill { get; set; }

  }
}
