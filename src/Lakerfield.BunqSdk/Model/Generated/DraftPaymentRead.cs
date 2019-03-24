using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("DraftPaymentRead")]
  public class DraftPaymentRead
  {
    /// <summary>
    /// The id of the created DrafPayment.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The id of the MonetaryAccount the DraftPayment applies to.
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_id")]
    public int MonetaryAccountId { get; set; }

    /// <summary>
    /// The label of the User who created the DraftPayment.
    /// </summary>
    [JsonProperty(PropertyName = "user_alias_created")]
    public LabelUser UserAliasCreated { get; set; }

    /// <summary>
    /// All responses to this draft payment.
    /// </summary>
    [JsonProperty(PropertyName = "responses")]
    public DraftPaymentResponse[] Responses { get; set; }

    /// <summary>
    /// The status of the DraftPayment.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The type of the DraftPayment.
    /// </summary>
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The entries in the DraftPayment.
    /// </summary>
    [JsonProperty(PropertyName = "entries")]
    public DraftPaymentEntry[] Entries { get; set; }

    /// <summary>
    /// The Payment or PaymentBatch. This will only be present after the DraftPayment has been accepted.
    /// </summary>
    [JsonProperty(PropertyName = "object")]
    public DraftPaymentAnchorObject Object { get; set; }

    /// <summary>
    /// The reference to the object used for split the bill. Can be RequestInquiry or RequestInquiryBatch
    /// </summary>
    [JsonProperty(PropertyName = "request_reference_split_the_bill")]
    public RequestInquiryReference[] RequestReferenceSplitTheBill { get; set; }

  }
}
