using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("AvatarCreate")]
  public class AvatarCreate
  {
    /// <summary>
    /// The UUID of the created avatar.
    /// </summary>
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

  }
}
