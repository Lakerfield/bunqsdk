using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CardMagStripePermission")]
  public class CardMagStripePermission
  {
    /// <summary>
    /// Expiry time of this rule.
    /// </summary>
    [JsonProperty(PropertyName = "expiry_time")]
    public string ExpiryTime { get; set; }

  }
}
