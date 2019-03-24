using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("ScheduleInstanceListing")]
  public class ScheduleInstanceListing
  {
    /// <summary>
    /// The state of the scheduleInstance. (FINISHED_SUCCESSFULLY, RETRY, FAILED_USER_ERROR)
    /// </summary>
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// The schedule start time (UTC).
    /// </summary>
    [JsonProperty(PropertyName = "time_start")]
    public string TimeStart { get; set; }

    /// <summary>
    /// The schedule end time (UTC).
    /// </summary>
    [JsonProperty(PropertyName = "time_end")]
    public string TimeEnd { get; set; }

    /// <summary>
    /// The message when the scheduled instance has run and failed due to user error.
    /// </summary>
    [JsonProperty(PropertyName = "error_message")]
    public Error[] ErrorMessage { get; set; }

    /// <summary>
    /// The scheduled object. (Payment, PaymentBatch)
    /// </summary>
    [JsonProperty(PropertyName = "scheduled_object")]
    public ScheduleAnchorObject ScheduledObject { get; set; }

    /// <summary>
    /// The result object of this schedule instance. (Payment, PaymentBatch)
    /// </summary>
    [JsonProperty(PropertyName = "result_object")]
    public ScheduleInstanceAnchorObject ResultObject { get; set; }

    /// <summary>
    /// The reference to the object used for split the bill. Can be RequestInquiry or RequestInquiryBatch
    /// </summary>
    [JsonProperty(PropertyName = "request_reference_split_the_bill")]
    public RequestInquiryReference[] RequestReferenceSplitTheBill { get; set; }

  }
}
