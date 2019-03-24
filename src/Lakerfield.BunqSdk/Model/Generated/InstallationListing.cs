using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("InstallationListing")]
  public class InstallationListing
  {
    /// <summary>
    /// The id of the Installation as created on the server. You can use this id to request the server's public key again.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
