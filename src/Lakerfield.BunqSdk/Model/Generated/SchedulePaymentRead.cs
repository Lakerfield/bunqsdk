using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("SchedulePaymentRead")]
  public class SchedulePaymentRead
  {
    /// <summary>
    /// The payment details.
    /// </summary>
    [JsonProperty(PropertyName = "payment")]
    public SchedulePaymentEntry Payment { get; set; }

    /// <summary>
    /// The schedule details.
    /// </summary>
    [JsonProperty(PropertyName = "schedule")]
    public Schedule Schedule { get; set; }

  }
}
