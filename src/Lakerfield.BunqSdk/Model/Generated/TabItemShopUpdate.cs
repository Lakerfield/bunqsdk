using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TabItemShopUpdate")]
  public class TabItemShopUpdate
  {
    /// <summary>
    /// The id of the modified TabItem.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
