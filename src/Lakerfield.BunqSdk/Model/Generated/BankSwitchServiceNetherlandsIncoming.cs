using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("BankSwitchServiceNetherlandsIncoming")]
  public class BankSwitchServiceNetherlandsIncoming
  {
    /// <summary>
    /// The label of the monetary of this switch service.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public LabelMonetaryAccount Alias { get; set; }

    /// <summary>
    /// The IBAN alias that's displayed for this switch service.
    /// </summary>
    [JsonProperty(PropertyName = "counterparty_alias")]
    public LabelMonetaryAccount CounterpartyAlias { get; set; }

    /// <summary>
    /// The status of the switch service.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The sub status of the switch service.
    /// </summary>
    [JsonProperty(PropertyName = "sub_status")]
    public string SubStatus { get; set; }

    /// <summary>
    /// The timestamp when the switch service actually starts.
    /// </summary>
    [JsonProperty(PropertyName = "time_start_actual")]
    public string TimeStartActual { get; set; }

    /// <summary>
    /// The label of the user creator of this switch service.
    /// </summary>
    [JsonProperty(PropertyName = "user_alias")]
    public LabelUser UserAlias { get; set; }

    /// <summary>
    /// The timestamp when the switch service desired to be start.
    /// </summary>
    [JsonProperty(PropertyName = "time_start_desired")]
    public string TimeStartDesired { get; set; }

    /// <summary>
    /// The timestamp when the switch service ends.
    /// </summary>
    [JsonProperty(PropertyName = "time_end")]
    public string TimeEnd { get; set; }

    /// <summary>
    /// Reference to the bank transfer form for this switch-service.
    /// </summary>
    [JsonProperty(PropertyName = "attachment")]
    public Attachment Attachment { get; set; }

  }
}
