using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("OauthClient")]
  public class OauthClient
  {
    /// <summary>
    /// The status of the Oauth Client, can be ACTIVE or CANCELLED.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

  }
}
