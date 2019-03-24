using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("FeatureAnnouncementRead")]
  public class FeatureAnnouncementRead
  {
    /// <summary>
    /// The Avatar of the event overview.
    /// </summary>
    [JsonProperty(PropertyName = "avatar")]
    public Avatar Avatar { get; set; }

    /// <summary>
    /// The event overview title of the feature display
    /// </summary>
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// The event overview subtitle of the feature display
    /// </summary>
    [JsonProperty(PropertyName = "sub_title")]
    public string SubTitle { get; set; }

  }
}
