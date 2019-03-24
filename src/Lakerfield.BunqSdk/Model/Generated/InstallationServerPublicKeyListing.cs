using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("InstallationServerPublicKeyListing")]
  public class InstallationServerPublicKeyListing
  {
    /// <summary>
    /// The server's public key for this Installation.
    /// </summary>
    [JsonProperty(PropertyName = "server_public_key")]
    public string ServerPublicKey { get; set; }

  }
}
