using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("AvatarRead")]
  public class AvatarRead
  {
    /// <summary>
    /// The UUID of the created avatar.
    /// </summary>
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// The content type of the image.
    /// </summary>
    [JsonProperty(PropertyName = "image")]
    public Image[] Image { get; set; }

  }
}
