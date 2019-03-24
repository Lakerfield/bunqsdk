using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TabItemShopCreate")]
  public class TabItemShopCreate
  {
    /// <summary>
    /// The id of the created TabItem.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
