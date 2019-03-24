using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("MonetaryAccountSetting")]
  public class MonetaryAccountSetting
  {
    /// <summary>
    /// The color chosen for the MonetaryAccount.
    /// </summary>
    [JsonProperty(PropertyName = "color")]
    public string Color { get; set; }

    /// <summary>
    /// The status of the avatar. Can be either AVATAR_DEFAULT, AVATAR_CUSTOM or AVATAR_UNDETERMINED.
    /// </summary>
    [JsonProperty(PropertyName = "default_avatar_status")]
    public string DefaultAvatarStatus { get; set; }

    /// <summary>
    /// The chat restriction. Possible values are ALLOW_INCOMING or BLOCK_INCOMING
    /// </summary>
    [JsonProperty(PropertyName = "restriction_chat")]
    public string RestrictionChat { get; set; }

  }
}
