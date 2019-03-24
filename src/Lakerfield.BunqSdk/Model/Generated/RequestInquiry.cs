using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("RequestInquiry")]
  public class RequestInquiry
  {
    /// <summary>
    /// The requested amount.
    /// </summary>
    [JsonProperty(PropertyName = "amount_inquired")]
    public Amount AmountInquired { get; set; }

    /// <summary>
    /// The LabelMonetaryAccount with the public information of the MonetaryAccount the money was requested from.
    /// </summary>
    [JsonProperty(PropertyName = "counterparty_alias")]
    public LabelMonetaryAccount CounterpartyAlias { get; set; }

    /// <summary>
    /// The description of the inquiry.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The attachments attached to the payment.
    /// </summary>
    [JsonProperty(PropertyName = "attachment")]
    public BunqId[] Attachment { get; set; }

    /// <summary>
    /// The client's custom reference that was attached to the request and the mutation.
    /// </summary>
    [JsonProperty(PropertyName = "merchant_reference")]
    public string MerchantReference { get; set; }

    /// <summary>
    /// The status of the request.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The minimum age the user accepting the RequestInquiry must have.
    /// </summary>
    [JsonProperty(PropertyName = "minimum_age")]
    public int MinimumAge { get; set; }

    /// <summary>
    /// Whether or not an address must be provided on accept.
    /// </summary>
    [JsonProperty(PropertyName = "require_address")]
    public string RequireAddress { get; set; }

    /// <summary>
    /// [DEPRECATED] Whether or not the accepting user can give an extra tip on top of the requested Amount. Defaults to false.
    /// </summary>
    [JsonProperty(PropertyName = "want_tip")]
    public bool WantTip { get; set; }

    /// <summary>
    /// [DEPRECATED] Whether or not the accepting user can choose to accept with a lower amount than requested. Defaults to false.
    /// </summary>
    [JsonProperty(PropertyName = "allow_amount_lower")]
    public bool AllowAmountLower { get; set; }

    /// <summary>
    /// [DEPRECATED] Whether or not the accepting user can choose to accept with a higher amount than requested. Defaults to false.
    /// </summary>
    [JsonProperty(PropertyName = "allow_amount_higher")]
    public bool AllowAmountHigher { get; set; }

    /// <summary>
    /// Whether or not sending a bunq.me request is allowed.
    /// </summary>
    [JsonProperty(PropertyName = "allow_bunqme")]
    public bool AllowBunqme { get; set; }

    /// <summary>
    /// The URL which the user is sent to after accepting or rejecting the Request.
    /// </summary>
    [JsonProperty(PropertyName = "redirect_url")]
    public string RedirectUrl { get; set; }

    /// <summary>
    /// The ID of the associated event if the request was made using 'split the bill'.
    /// </summary>
    [JsonProperty(PropertyName = "event_id")]
    public int EventId { get; set; }

    /// <summary>
    /// The id of the created RequestInquiry.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the payment request's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the payment request's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The timestamp of when the payment request was responded to.
    /// </summary>
    [JsonProperty(PropertyName = "time_responded")]
    public string TimeResponded { get; set; }

    /// <summary>
    /// The timestamp of when the payment request expired.
    /// </summary>
    [JsonProperty(PropertyName = "time_expiry")]
    public string TimeExpiry { get; set; }

    /// <summary>
    /// The id of the monetary account the request response applies to.
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_id")]
    public int MonetaryAccountId { get; set; }

    /// <summary>
    /// The responded amount.
    /// </summary>
    [JsonProperty(PropertyName = "amount_responded")]
    public Amount AmountResponded { get; set; }

    /// <summary>
    /// The label that's displayed to the counterparty with the mutation. Includes user.
    /// </summary>
    [JsonProperty(PropertyName = "user_alias_created")]
    public LabelUser UserAliasCreated { get; set; }

    /// <summary>
    /// The label that's displayed to the counterparty with the mutation. Includes user.
    /// </summary>
    [JsonProperty(PropertyName = "user_alias_revoked")]
    public LabelUser UserAliasRevoked { get; set; }

    /// <summary>
    /// The id of the batch if the request was part of a batch.
    /// </summary>
    [JsonProperty(PropertyName = "batch_id")]
    public int BatchId { get; set; }

    /// <summary>
    /// The id of the scheduled job if the request was scheduled.
    /// </summary>
    [JsonProperty(PropertyName = "scheduled_id")]
    public int ScheduledId { get; set; }

    /// <summary>
    /// The url that points to the bunq.me request.
    /// </summary>
    [JsonProperty(PropertyName = "bunqme_share_url")]
    public string BunqmeShareUrl { get; set; }

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
    /// The geolocation where the payment was done.
    /// </summary>
    [JsonProperty(PropertyName = "geolocation")]
    public Geolocation Geolocation { get; set; }

    /// <summary>
    /// Whether or not chat messages are allowed.
    /// </summary>
    [JsonProperty(PropertyName = "allow_chat")]
    public bool AllowChat { get; set; }

    /// <summary>
    /// The reference to the object used for split the bill. Can be Payment, PaymentBatch, ScheduleInstance, RequestResponse and MasterCardAction
    /// </summary>
    [JsonProperty(PropertyName = "reference_split_the_bill")]
    public RequestReferenceSplitTheBillAnchorObject ReferenceSplitTheBill { get; set; }

  }
}
