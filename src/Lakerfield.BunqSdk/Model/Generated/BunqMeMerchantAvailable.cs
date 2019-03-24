using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("BunqMeMerchantAvailable")]
  public class BunqMeMerchantAvailable
  {
    /// <summary>
    /// A merchant type supported by bunq.me.
    /// </summary>
    [JsonProperty(PropertyName = "merchant_type")]
    public string MerchantType { get; set; }

    /// <summary>
    /// Whether or not the merchant is available for the user.
    /// </summary>
    [JsonProperty(PropertyName = "available")]
    public bool Available { get; set; }

  }
}
