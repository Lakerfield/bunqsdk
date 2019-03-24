using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("MonetaryAccountProfileFill")]
  public class MonetaryAccountProfileFill
  {
    /// <summary>
    /// The status of the profile.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The goal balance.
    /// </summary>
    [JsonProperty(PropertyName = "balance_preferred")]
    public Amount BalancePreferred { get; set; }

    /// <summary>
    /// The low threshold balance.
    /// </summary>
    [JsonProperty(PropertyName = "balance_threshold_low")]
    public Amount BalanceThresholdLow { get; set; }

    /// <summary>
    /// The method used to fill the monetary account. Currently only iDEAL is supported, and it is the default one.
    /// </summary>
    [JsonProperty(PropertyName = "method_fill")]
    public string MethodFill { get; set; }

    /// <summary>
    /// The bank the fill is supposed to happen from, with BIC and bank name.
    /// </summary>
    [JsonProperty(PropertyName = "issuer")]
    public Issuer Issuer { get; set; }

  }
}
