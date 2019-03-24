using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("Avatar")]
  public class Avatar
  {
    /// <summary>
    /// The public UUID of the avatar.
    /// </summary>
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// The public UUID of object this avatar is anchored to.
    /// </summary>
    [JsonProperty(PropertyName = "anchor_uuid")]
    public string AnchorUuid { get; set; }

    /// <summary>
    /// The actual image information of this avatar.
    /// </summary>
    [JsonProperty(PropertyName = "image")]
    public Image[] Image { get; set; }

  }
}
