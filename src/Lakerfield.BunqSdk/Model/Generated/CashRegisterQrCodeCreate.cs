using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CashRegisterQrCodeCreate")]
  public class CashRegisterQrCodeCreate
  {
    /// <summary>
    /// The id of the created QR code. Use this id to get the RAW content of the QR code with: ../qr-code/{id}/content
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
