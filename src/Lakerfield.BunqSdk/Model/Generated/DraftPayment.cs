using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("DraftPayment")]
  public class DraftPayment
  {
    /// <summary>
    /// The status of the DraftPayment.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The list of entries in the DraftPayment. Each entry will result in a payment when the DraftPayment is accepted.
    /// </summary>
    [JsonProperty(PropertyName = "entries")]
    public DraftPaymentEntry[] Entries { get; set; }

    /// <summary>
    /// The last updated_timestamp that you received for this DraftPayment. This needs to be provided to prevent race conditions.
    /// </summary>
    [JsonProperty(PropertyName = "previous_updated_timestamp")]
    public string PreviousUpdatedTimestamp { get; set; }

    /// <summary>
    /// The number of accepts that are required for the draft payment to receive status ACCEPTED. Currently only 1 is valid.
    /// </summary>
    [JsonProperty(PropertyName = "number_of_required_accepts")]
    public int NumberOfRequiredAccepts { get; set; }

  }
}
