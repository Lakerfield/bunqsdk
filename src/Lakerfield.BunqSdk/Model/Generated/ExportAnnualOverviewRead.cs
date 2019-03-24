using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("ExportAnnualOverviewRead")]
  public class ExportAnnualOverviewRead
  {
    /// <summary>
    /// The id of the annual overview as created on the server.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the annual overview 's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the annual overview 's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The year for which the overview is.
    /// </summary>
    [JsonProperty(PropertyName = "year")]
    public int Year { get; set; }

    /// <summary>
    /// The user to which this annual overview belongs.
    /// </summary>
    [JsonProperty(PropertyName = "alias_user")]
    public LabelUser AliasUser { get; set; }

  }
}
