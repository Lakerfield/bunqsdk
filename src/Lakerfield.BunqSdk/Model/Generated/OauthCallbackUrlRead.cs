using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("OauthCallbackUrlRead")]
  public class OauthCallbackUrlRead
  {
    /// <summary>
    /// The URL for this callback.
    /// </summary>
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

  }
}
