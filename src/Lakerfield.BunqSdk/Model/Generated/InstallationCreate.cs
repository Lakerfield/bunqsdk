using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("InstallationCreate")]
  public class InstallationCreate
  {
    /// <summary>
    /// The Id object of the created Installation
    /// </summary>
    [JsonProperty(PropertyName = "Id")]
    public BunqId Id { get; set; }

    /// <summary>
    /// The Token object of this Installation.
    /// </summary>
    [JsonProperty(PropertyName = "Token")]
    public InstallationToken Token { get; set; }

    /// <summary>
    /// The ServerPublicKey object of the created Installation
    /// </summary>
    [JsonProperty(PropertyName = "ServerPublicKey")]
    public InstallationServerPublicKey Serverpublickey { get; set; }

  }
}
