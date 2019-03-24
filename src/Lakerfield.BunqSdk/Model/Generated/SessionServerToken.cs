using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("SessionServerToken")]
  public class SessionServerToken
  {
    /// <summary>
    /// The id of the Token.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The Session token is the token the client has to provide in the "X-Bunq-Client-Authentication" header for each API call that requires a Session (only the creation of a Installation and DeviceServer don't require a Session).
    /// </summary>
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

  }
}
