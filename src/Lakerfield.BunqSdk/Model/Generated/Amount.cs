using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("Amount")]
  public class Amount
  {
    /// <summary>
    /// The amount formatted to two decimal places.
    /// </summary>
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// The currency of the amount. It is an ISO 4217 formatted currency code.
    /// </summary>
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

  }
}
