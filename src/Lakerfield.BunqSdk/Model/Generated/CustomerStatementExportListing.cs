using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CustomerStatementExportListing")]
  public class CustomerStatementExportListing
  {
    /// <summary>
    /// The id of the customer statement model.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the statement model's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the statement model's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The date from when this statement shows transactions.
    /// </summary>
    [JsonProperty(PropertyName = "date_start")]
    public string DateStart { get; set; }

    /// <summary>
    /// The date until which statement shows transactions.
    /// </summary>
    [JsonProperty(PropertyName = "date_end")]
    public string DateEnd { get; set; }

    /// <summary>
    /// The status of the export.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// MT940 Statement number. Unique per monetary account.
    /// </summary>
    [JsonProperty(PropertyName = "statement_number")]
    public int StatementNumber { get; set; }

    /// <summary>
    /// The format of statement.
    /// </summary>
    [JsonProperty(PropertyName = "statement_format")]
    public string StatementFormat { get; set; }

    /// <summary>
    /// The regional format of a CSV statement.
    /// </summary>
    [JsonProperty(PropertyName = "regional_format")]
    public string RegionalFormat { get; set; }

    /// <summary>
    /// The monetary account for which this statement was created.
    /// </summary>
    [JsonProperty(PropertyName = "alias_monetary_account")]
    public LabelMonetaryAccount AliasMonetaryAccount { get; set; }

  }
}
