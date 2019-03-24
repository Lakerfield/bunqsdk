using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CertificatePinnedListing")]
  public class CertificatePinnedListing
  {
    /// <summary>
    /// The certificate chain in .PEM format. Certificates are glued with newline characters.
    /// </summary>
    [JsonProperty(PropertyName = "certificate_chain")]
    public string CertificateChain { get; set; }

    /// <summary>
    /// The id generated for the pinned certificate chain.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
