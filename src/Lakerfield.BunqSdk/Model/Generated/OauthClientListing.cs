using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("OauthClientListing")]
  public class OauthClientListing
  {
    /// <summary>
    /// The status of the pack group, can be ACTIVE, CANCELLED or CANCELLED_PENDING.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The Client ID associated with this Oauth Client
    /// </summary>
    [JsonProperty(PropertyName = "client_id")]
    public string ClientId { get; set; }

    /// <summary>
    /// Secret associated with this Oauth Client
    /// </summary>
    [JsonProperty(PropertyName = "secret")]
    public string Secret { get; set; }

    /// <summary>
    /// The callback URLs which are bound to this Oauth Client
    /// </summary>
    [JsonProperty(PropertyName = "callback_url")]
    public OauthCallbackUrl CallbackUrl { get; set; }

  }
}
