using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("PaymentBatchListing")]
  public class PaymentBatchListing
  {
    /// <summary>
    /// The list of mutations that were made.
    /// </summary>
    [JsonProperty(PropertyName = "payments")]
    public Payment[] Payments { get; set; }

  }
}
