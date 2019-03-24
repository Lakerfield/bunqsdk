using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("MonetaryAccountProfileDrain")]
  public class MonetaryAccountProfileDrain
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
    /// The high threshold balance.
    /// </summary>
    [JsonProperty(PropertyName = "balance_threshold_high")]
    public Amount BalanceThresholdHigh { get; set; }

    /// <summary>
    /// The savings monetary account.
    /// </summary>
    [JsonProperty(PropertyName = "savings_account_alias")]
    public LabelMonetaryAccount SavingsAccountAlias { get; set; }

  }
}
