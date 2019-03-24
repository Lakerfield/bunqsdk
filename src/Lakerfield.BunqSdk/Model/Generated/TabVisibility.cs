using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TabVisibility")]
  public class TabVisibility
  {
    /// <summary>
    /// When true the tab will be linked to the ACTIVE cash registers QR code.
    /// </summary>
    [JsonProperty(PropertyName = "cash_register_qr_code")]
    public bool CashRegisterQrCode { get; set; }

    /// <summary>
    /// When true the tab will be visible through its own QR code. Use ../tab/{tab-id}/qr-code-content to get the raw content of this QR code
    /// </summary>
    [JsonProperty(PropertyName = "tab_qr_code")]
    public bool TabQrCode { get; set; }

    /// <summary>
    /// The location of the Tab in NearPay.
    /// </summary>
    [JsonProperty(PropertyName = "location")]
    public Geolocation Location { get; set; }

  }
}
