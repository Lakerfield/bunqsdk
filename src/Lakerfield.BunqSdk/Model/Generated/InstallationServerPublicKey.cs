using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("ServerPublicKey")]
  public class InstallationServerPublicKey
  {
    /// <summary>
    /// The server's public key for this Installation. You should use this key to verify the "X-Bunq-Server-Signature" header for each response from the server.
    /// </summary>
    [JsonProperty(PropertyName = "server_public_key")]
    public string ServerPublicKey { get; set; }

  }
}
