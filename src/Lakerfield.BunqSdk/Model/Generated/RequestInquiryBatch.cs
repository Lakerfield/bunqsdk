using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("RequestInquiryBatch")]
  public class RequestInquiryBatch
  {
    /// <summary>
    /// The list of requests that were made.
    /// </summary>
    [JsonProperty(PropertyName = "request_inquiries")]
    public RequestInquiry[] RequestInquiries { get; set; }

    /// <summary>
    /// The status of the request.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The total amount originally inquired for this batch.
    /// </summary>
    [JsonProperty(PropertyName = "total_amount_inquired")]
    public Amount TotalAmountInquired { get; set; }

    /// <summary>
    /// The ID of the associated event if the request batch was made using 'split the bill'.
    /// </summary>
    [JsonProperty(PropertyName = "event_id")]
    public int EventId { get; set; }

    /// <summary>
    /// The reference to the object used for split the bill. Can be Payment, PaymentBatch, ScheduleInstance, RequestResponse and MasterCardAction
    /// </summary>
    [JsonProperty(PropertyName = "reference_split_the_bill")]
    public RequestReferenceSplitTheBillAnchorObject ReferenceSplitTheBill { get; set; }

  }
}
