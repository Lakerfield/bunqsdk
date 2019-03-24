using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CashRegisterListing")]
  public class CashRegisterListing
  {
    /// <summary>
    /// The id of the created CashRegister.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the CashRegister's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the CashRegister's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The name of the CashRegister.
    /// </summary>
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The status of the CashRegister. Can be PENDING_APPROVAL, ACTIVE, DENIED or CLOSED.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The Avatar of the CashRegister.
    /// </summary>
    [JsonProperty(PropertyName = "avatar")]
    public Avatar Avatar { get; set; }

    /// <summary>
    /// The geolocation of the CashRegister. Can be null.
    /// </summary>
    [JsonProperty(PropertyName = "location")]
    public Geolocation Location { get; set; }

    /// <summary>
    /// The types of notifications that will result in a push notification or URL callback for this CashRegister.
    /// </summary>
    [JsonProperty(PropertyName = "notification_filters")]
    public NotificationFilter[] NotificationFilters { get; set; }

    /// <summary>
    /// The tab text for waiting screen of CashRegister.
    /// </summary>
    [JsonProperty(PropertyName = "tab_text_waiting_screen")]
    public TabTextWaitingScreen[] TabTextWaitingScreen { get; set; }

  }
}
