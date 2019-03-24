using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("SchedulePaymentBatch")]
  public class SchedulePaymentBatch
  {
    /// <summary>
    /// The payment details.
    /// </summary>
    [JsonProperty(PropertyName = "payments")]
    public SchedulePaymentEntry[] Payments { get; set; }

    /// <summary>
    /// The schedule details.
    /// </summary>
    [JsonProperty(PropertyName = "schedule")]
    public Schedule Schedule { get; set; }

  }
}
