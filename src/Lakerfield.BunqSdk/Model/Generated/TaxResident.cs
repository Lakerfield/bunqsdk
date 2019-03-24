using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TaxResident")]
  public class TaxResident
  {
    /// <summary>
    /// The country of the tax number.
    /// </summary>
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// The tax number.
    /// </summary>
    [JsonProperty(PropertyName = "tax_number")]
    public string TaxNumber { get; set; }

    /// <summary>
    /// The status of the tax number. Either CONFIRMED or UNCONFIRMED.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

  }
}
