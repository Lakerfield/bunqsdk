using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CardCountryPermission")]
  public class CardCountryPermission
  {
    /// <summary>
    /// The country to allow transactions in (e.g. NL, DE).
    /// </summary>
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Expiry time of this rule.
    /// </summary>
    [JsonProperty(PropertyName = "expiry_time")]
    public string ExpiryTime { get; set; }

    /// <summary>
    /// The id of the card country permission entry.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
