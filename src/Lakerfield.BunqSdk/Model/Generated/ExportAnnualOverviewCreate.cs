using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("ExportAnnualOverviewCreate")]
  public class ExportAnnualOverviewCreate
  {
    /// <summary>
    /// The id of the annual overview as created on the server.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
