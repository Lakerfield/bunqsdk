using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TokenQrRequestIdeal")]
  public class TokenQrRequestIdeal
  {
    /// <summary>
    /// The token passed from a site or read from a QR code.
    /// </summary>
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

  }
}
