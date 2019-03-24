using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TabItemShop")]
  public class TabItemShop
  {
    /// <summary>
    /// The TabItem's brief description.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The TabItem's EAN code.
    /// </summary>
    [JsonProperty(PropertyName = "ean_code")]
    public string EanCode { get; set; }

    /// <summary>
    /// An AttachmentPublic UUID that used as an avatar for the TabItem.
    /// </summary>
    [JsonProperty(PropertyName = "avatar_attachment_uuid")]
    public string AvatarAttachmentUuid { get; set; }

    /// <summary>
    /// A list of AttachmentTab attached to the TabItem.
    /// </summary>
    [JsonProperty(PropertyName = "tab_attachment")]
    public AttachmentTab[] TabAttachment { get; set; }

    /// <summary>
    /// The quantity of the TabItem.
    /// </summary>
    [JsonProperty(PropertyName = "quantity")]
    public int Quantity { get; set; }

    /// <summary>
    /// The money amount of the TabItem.
    /// </summary>
    [JsonProperty(PropertyName = "amount")]
    public Amount Amount { get; set; }

    /// <summary>
    /// The id of the created TabItem.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// A struct with an AttachmentPublic UUID that used as an avatar for the TabItem.
    /// </summary>
    [JsonProperty(PropertyName = "avatar_attachment")]
    public AttachmentPublic AvatarAttachment { get; set; }

  }
}
