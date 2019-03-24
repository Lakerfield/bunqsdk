using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("NoteTextBankSwitchServiceNetherlandsIncomingPaymentCreate")]
  public class NoteTextBankSwitchServiceNetherlandsIncomingPaymentCreate
  {
    /// <summary>
    /// The id of the created item
    /// </summary>
    [JsonProperty(PropertyName = "Id")]
    public BunqId Id { get; set; }

  }
}
