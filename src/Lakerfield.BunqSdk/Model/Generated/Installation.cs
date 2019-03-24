using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("Installation")]
  public class Installation
  {
    /// <summary>
    /// Your public key. This is the public part of the key pair that you are going to use to create value of the "X-Bunq-Client-Signature" header for all future API calls.
    /// </summary>
    [JsonProperty(PropertyName = "client_public_key")]
    public string ClientPublicKey { get; set; }

  }
}
