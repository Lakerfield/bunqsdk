using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("WhitelistSdd")]
  public class WhitelistSdd
  {
    /// <summary>
    /// ID of the monetary account of which you want to pay from.
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_paying_id")]
    public int MonetaryAccountPayingId { get; set; }

    /// <summary>
    /// ID of the request for which you want to whitelist the originating SDD.
    /// </summary>
    [JsonProperty(PropertyName = "request_id")]
    public int RequestId { get; set; }

    /// <summary>
    /// The maximum amount of money that is allowed to be deducted based on the whitelist.
    /// </summary>
    [JsonProperty(PropertyName = "maximum_amount_per_month")]
    public Amount MaximumAmountPerMonth { get; set; }

  }
}
