using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("MonetaryAccountRead")]
  public class MonetaryAccountRead
  {
    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "MonetaryAccountBank")]
    public MonetaryAccountBank Monetaryaccountbank { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "MonetaryAccountJoint")]
    public MonetaryAccountJoint Monetaryaccountjoint { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "MonetaryAccountLight")]
    public MonetaryAccountLight Monetaryaccountlight { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "MonetaryAccountSavings")]
    public MonetaryAccountSavings Monetaryaccountsavings { get; set; }

  }
}
