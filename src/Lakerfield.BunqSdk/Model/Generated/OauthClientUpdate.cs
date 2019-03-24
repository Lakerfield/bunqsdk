using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("OauthClientUpdate")]
  public class OauthClientUpdate
  {
    /// <summary>
    /// The id of the created item
    /// </summary>
    [JsonProperty(PropertyName = "Id")]
    public BunqId Id { get; set; }

  }
}
