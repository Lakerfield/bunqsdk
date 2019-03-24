using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("DraftPaymentAnchorObject")]
  public class DraftPaymentAnchorObject
  {
    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "Payment")]
    public Payment Payment { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "PaymentBatch")]
    public PaymentBatch Paymentbatch { get; set; }

  }
}
