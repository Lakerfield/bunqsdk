using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("WhitelistResult")]
  public class WhitelistResult
  {
    /// <summary>
    /// The ID of the whitelist entry.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The account from which payments will be deducted when a transaction is matched with this whitelist.
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_paying_id")]
    public int MonetaryAccountPayingId { get; set; }

    /// <summary>
    /// The status of the WhitelistResult.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The message when the whitelist result has failed due to user error.
    /// </summary>
    [JsonProperty(PropertyName = "error_message")]
    public Error[] ErrorMessage { get; set; }

    /// <summary>
    /// The corresponding whitelist.
    /// </summary>
    [JsonProperty(PropertyName = "whitelist")]
    public Whitelist Whitelist { get; set; }

    /// <summary>
    /// The details of the external object the event was created for.
    /// </summary>
    [JsonProperty(PropertyName = "object")]
    public WhitelistResultViewAnchoredObject Object { get; set; }

    /// <summary>
    /// The reference to the object used for split the bill. Can be RequestInquiry or RequestInquiryBatch
    /// </summary>
    [JsonProperty(PropertyName = "request_reference_split_the_bill")]
    public RequestInquiryReference[] RequestReferenceSplitTheBill { get; set; }

  }
}
