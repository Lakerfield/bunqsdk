using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CertificatePinned")]
  public class CertificatePinned
  {
    /// <summary>
    /// The certificate chain in .PEM format.
    /// </summary>
    [JsonProperty(PropertyName = "certificate_chain")]
    public Certificate[] CertificateChain { get; set; }

  }
}
