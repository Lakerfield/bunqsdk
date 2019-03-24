using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("InstallationToken")]
  public class InstallationToken
  {
    /// <summary>
    /// The id of the Token.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the Token's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the Token's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The installation token is the token the client has to provide in the "X-Bunq-Client-Authentication" header for the creation of a DeviceServer and SessionServer.
    /// </summary>
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

  }
}
