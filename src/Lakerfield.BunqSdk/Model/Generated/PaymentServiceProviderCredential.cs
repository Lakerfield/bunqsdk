using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("PaymentServiceProviderCredential")]
  public class PaymentServiceProviderCredential
  {
    /// <summary>
    /// Payment Services Directive 2 compatible QSEAL certificate
    /// </summary>
    [JsonProperty(PropertyName = "client_payment_service_provider_certificate")]
    public string ClientPaymentServiceProviderCertificate { get; set; }

    /// <summary>
    /// Intermediate and root certificate belonging to the provided certificate.
    /// </summary>
    [JsonProperty(PropertyName = "client_payment_service_provider_certificate_chain")]
    public string ClientPaymentServiceProviderCertificateChain { get; set; }

    /// <summary>
    /// The Base64 encoded signature of the public key provided during installation and with the installation token appended as a nonce. Signed with the private key belonging to the QSEAL certificate.
    /// </summary>
    [JsonProperty(PropertyName = "client_public_key_signature")]
    public string ClientPublicKeySignature { get; set; }

  }
}
