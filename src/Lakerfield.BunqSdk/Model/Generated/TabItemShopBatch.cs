using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TabItemShopBatch")]
  public class TabItemShopBatch
  {
    /// <summary>
    /// The list of tab items we want to create in a single batch. Limited to 50 items per batch.
    /// </summary>
    [JsonProperty(PropertyName = "tab_items")]
    public TabItemShop[] TabItems { get; set; }

  }
}
