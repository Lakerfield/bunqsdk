using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CustomerStatementExport")]
  public class CustomerStatementExport
  {
    /// <summary>
    /// The format type of statement. Allowed values: MT940, CSV, PDF.
    /// </summary>
    [JsonProperty(PropertyName = "statement_format")]
    public string StatementFormat { get; set; }

    /// <summary>
    /// The start date for making statements.
    /// </summary>
    [JsonProperty(PropertyName = "date_start")]
    public string DateStart { get; set; }

    /// <summary>
    /// The end date for making statements.
    /// </summary>
    [JsonProperty(PropertyName = "date_end")]
    public string DateEnd { get; set; }

    /// <summary>
    /// Required for CSV exports. The regional format of the statement, can be UK_US (comma-separated) or EUROPEAN (semicolon-separated).
    /// </summary>
    [JsonProperty(PropertyName = "regional_format")]
    public string RegionalFormat { get; set; }

  }
}
