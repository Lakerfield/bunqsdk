using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("Tab")]
  public class Tab
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
