using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TabListing")]
  public class TabListing
  {
    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "TabUsageSingle")]
    public TabUsageSingle Tabusagesingle { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "TabUsageMultiple")]
    public TabUsageMultiple Tabusagemultiple { get; set; }

  }
}
