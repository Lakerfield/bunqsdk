using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("NoteTextBankSwitchServiceNetherlandsIncomingPayment")]
  public class NoteTextBankSwitchServiceNetherlandsIncomingPayment
  {
    /// <summary>
    /// The content of the note.
    /// </summary>
    [JsonProperty(PropertyName = "content")]
    public string Content { get; set; }

  }
}
