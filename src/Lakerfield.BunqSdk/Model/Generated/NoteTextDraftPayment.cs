using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("NoteTextDraftPayment")]
  public class NoteTextDraftPayment
  {
    /// <summary>
    /// The content of the note.
    /// </summary>
    [JsonProperty(PropertyName = "content")]
    public string Content { get; set; }

  }
}
