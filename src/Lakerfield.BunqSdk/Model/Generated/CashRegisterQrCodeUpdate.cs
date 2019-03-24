using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CashRegisterQrCodeUpdate")]
  public class CashRegisterQrCodeUpdate
  {
    /// <summary>
    /// The id of the updated QR code. Use this id to get the RAW content of the QR code with: ../qr-code/{id}/content
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
