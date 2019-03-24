using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CashRegisterQrCodeListing")]
  public class CashRegisterQrCodeListing
  {
    /// <summary>
    /// The id of the created QR code. Use this id to get the RAW content of the QR code with: ../qr-code/{id}/content
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the QR code's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the TokenQrCashRegister's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The status of this QR code. If the status is "ACTIVE" the QR code can be scanned to see the linked CashRegister and tab. If the status is "INACTIVE" the QR code does not link to a anything.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The CashRegister that is linked to the token.
    /// </summary>
    [JsonProperty(PropertyName = "cash_register")]
    public CashRegister CashRegister { get; set; }

    /// <summary>
    /// Holds the Tab object. Can be TabUsageSingle, TabUsageMultiple or null
    /// </summary>
    [JsonProperty(PropertyName = "tab_object")]
    public Tab TabObject { get; set; }

  }
}
