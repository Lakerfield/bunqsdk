using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CardVirtualPrimaryAccountNumber")]
  public class CardVirtualPrimaryAccountNumber
  {
    /// <summary>
    /// The ID for this Virtual PAN.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The description for this Virtual PAN.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The status for this Virtual PAN.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The ID of the monetary account to assign to this Virtual PAN.
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_id")]
    public int MonetaryAccountId { get; set; }

    /// <summary>
    /// The UUID for this Virtual PAN.
    /// </summary>
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// The last four digits of the Virtual PAN.
    /// </summary>
    [JsonProperty(PropertyName = "four_digit")]
    public string FourDigit { get; set; }

  }
}
