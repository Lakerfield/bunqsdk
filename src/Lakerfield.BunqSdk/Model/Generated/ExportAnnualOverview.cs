using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("ExportAnnualOverview")]
  public class ExportAnnualOverview
  {
    /// <summary>
    /// The year for which the overview is.
    /// </summary>
    [JsonProperty(PropertyName = "year")]
    public int Year { get; set; }

  }
}
