using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("BankSwitchServiceNetherlandsIncomingPayment")]
  public class BankSwitchServiceNetherlandsIncomingPayment
  {
    /// <summary>
    /// The bank switch service details.
    /// </summary>
    [JsonProperty(PropertyName = "bank_switch_service")]
    public BankSwitchServiceNetherlandsIncoming BankSwitchService { get; set; }

    /// <summary>
    /// The payment made using bank switch service.
    /// </summary>
    [JsonProperty(PropertyName = "payment")]
    public Payment Payment { get; set; }

  }
}
