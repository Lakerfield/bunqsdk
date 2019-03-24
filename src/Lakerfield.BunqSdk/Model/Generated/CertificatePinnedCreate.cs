using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CertificatePinnedCreate")]
  public class CertificatePinnedCreate
  {
    /// <summary>
    /// The id generated for the pinned certificate chain.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
