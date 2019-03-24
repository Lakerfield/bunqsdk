using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("RequestInquiryBatchListing")]
  public class RequestInquiryBatchListing
  {
    /// <summary>
    /// The list of requests that were made.
    /// </summary>
    [JsonProperty(PropertyName = "request_inquiries")]
    public RequestInquiry[] RequestInquiries { get; set; }

    /// <summary>
    /// The total amount originally inquired for this batch.
    /// </summary>
    [JsonProperty(PropertyName = "total_amount_inquired")]
    public Amount TotalAmountInquired { get; set; }

    /// <summary>
    /// The reference to the object used for split the bill. Can be Payment, PaymentBatch, ScheduleInstance, RequestResponse and MasterCardAction
    /// </summary>
    [JsonProperty(PropertyName = "reference_split_the_bill")]
    public RequestReferenceSplitTheBillAnchorObject ReferenceSplitTheBill { get; set; }

  }
}
