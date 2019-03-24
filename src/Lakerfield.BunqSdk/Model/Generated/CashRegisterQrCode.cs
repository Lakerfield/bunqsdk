using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CashRegisterQrCode")]
  public class CashRegisterQrCode
  {
    /// <summary>
    /// The status of the QR code. ACTIVE or INACTIVE. Only one QR code can be ACTIVE for a CashRegister at any time. Setting a QR code to ACTIVE will deactivate any other CashRegister QR codes.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

  }
}
