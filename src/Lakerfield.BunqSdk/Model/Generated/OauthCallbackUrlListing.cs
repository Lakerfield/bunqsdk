using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("OauthCallbackUrlListing")]
  public class OauthCallbackUrlListing
  {
    /// <summary>
    /// The URL for this callback.
    /// </summary>
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

  }
}
