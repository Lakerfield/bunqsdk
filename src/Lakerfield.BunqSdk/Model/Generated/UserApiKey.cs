using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("UserApiKey")]
  public class UserApiKey
  {
    /// <summary>
    /// The id of the user.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the user object's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the user object's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The user who requested access.
    /// </summary>
    [JsonProperty(PropertyName = "requested_by_user")]
    public UserApiKeyAnchoredUser RequestedByUser { get; set; }

    /// <summary>
    /// The user who granted access.
    /// </summary>
    [JsonProperty(PropertyName = "granted_by_user")]
    public UserApiKeyAnchoredUser GrantedByUser { get; set; }

  }
}
