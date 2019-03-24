using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("LabelUser")]
  public class LabelUser
  {
    /// <summary>
    /// The public UUID of the label-user.
    /// </summary>
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// The name to be displayed for this user, as it was given on the request.
    /// </summary>
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// The country of the user. 000 stands for "unknown"
    /// </summary>
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// The current avatar of the user.
    /// </summary>
    [JsonProperty(PropertyName = "avatar")]
    public Avatar Avatar { get; set; }

    /// <summary>
    /// The current nickname of the user.
    /// </summary>
    [JsonProperty(PropertyName = "public_nick_name")]
    public string PublicNickName { get; set; }

  }
}
