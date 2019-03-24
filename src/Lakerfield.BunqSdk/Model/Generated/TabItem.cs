using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TabItem")]
  public class TabItem
  {
    /// <summary>
    /// The id of the tab item.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The item's brief description.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The item's EAN code.
    /// </summary>
    [JsonProperty(PropertyName = "ean_code")]
    public string EanCode { get; set; }

    /// <summary>
    /// A struct with an AttachmentPublic UUID that used as an avatar for the TabItem.
    /// </summary>
    [JsonProperty(PropertyName = "avatar_attachment")]
    public AttachmentPublic AvatarAttachment { get; set; }

    /// <summary>
    /// A list of AttachmentTab attached to the TabItem.
    /// </summary>
    [JsonProperty(PropertyName = "tab_attachment")]
    public AttachmentTab[] TabAttachment { get; set; }

    /// <summary>
    /// The quantity of the item. Formatted as a number containing up to 15 digits, up to 15 decimals and using a dot.
    /// </summary>
    [JsonProperty(PropertyName = "quantity")]
    public string Quantity { get; set; }

    /// <summary>
    /// The money amount of the item.
    /// </summary>
    [JsonProperty(PropertyName = "amount")]
    public Amount Amount { get; set; }

  }
}
