using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("OauthCallbackUrl")]
  public class OauthCallbackUrl
  {
    /// <summary>
    /// The URL for this callback.
    /// </summary>
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

  }
}
