using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TabUsageMultipleListing")]
  public class TabUsageMultipleListing
  {
    /// <summary>
    /// The uuid of the created TabUsageMultiple.
    /// </summary>
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// The timestamp of the Tab's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the Tab's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The description of the TabUsageMultiple. Maximum 9000 characters.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The status of the Tab. Can be OPEN, PAYABLE or CLOSED.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The total amount of the Tab.
    /// </summary>
    [JsonProperty(PropertyName = "amount_total")]
    public Amount AmountTotal { get; set; }

    /// <summary>
    /// The token used to redirect mobile devices directly to the bunq app. Because they can't scan a QR code.
    /// </summary>
    [JsonProperty(PropertyName = "qr_code_token")]
    public string QrCodeToken { get; set; }

    /// <summary>
    /// The URL redirecting user to the tab payment in the bunq app. Only works on mobile devices.
    /// </summary>
    [JsonProperty(PropertyName = "tab_url")]
    public string TabUrl { get; set; }

    /// <summary>
    /// The visibility of a Tab. A Tab can be visible trough NearPay, the QR code of the CashRegister and its own QR code.
    /// </summary>
    [JsonProperty(PropertyName = "visibility")]
    public TabVisibility Visibility { get; set; }

    /// <summary>
    /// The minimum age of the user paying the Tab.
    /// </summary>
    [JsonProperty(PropertyName = "minimum_age")]
    public bool MinimumAge { get; set; }

    /// <summary>
    /// Whether or not an billing and shipping address must be provided when paying the Tab.
    /// </summary>
    [JsonProperty(PropertyName = "require_address")]
    public string RequireAddress { get; set; }

    /// <summary>
    /// The URL which the user is sent to after paying the Tab.
    /// </summary>
    [JsonProperty(PropertyName = "redirect_url")]
    public string RedirectUrl { get; set; }

    /// <summary>
    /// The moment when this Tab expires.
    /// </summary>
    [JsonProperty(PropertyName = "expiration")]
    public string Expiration { get; set; }

    /// <summary>
    /// The alias of the party that owns this tab.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public LabelMonetaryAccount Alias { get; set; }

    /// <summary>
    /// The location of the cash register that created this tab.
    /// </summary>
    [JsonProperty(PropertyName = "cash_register_location")]
    public Geolocation CashRegisterLocation { get; set; }

    /// <summary>
    /// The tab items of this tab.
    /// </summary>
    [JsonProperty(PropertyName = "tab_item")]
    public TabItem[] TabItem { get; set; }

    /// <summary>
    /// An array of attachments that describe the tab. Viewable through the GET /tab/{tabid}/attachment/{attachmentid}/content endpoint.
    /// </summary>
    [JsonProperty(PropertyName = "tab_attachment")]
    public BunqId[] TabAttachment { get; set; }

  }
}
