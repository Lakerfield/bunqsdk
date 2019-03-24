using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("NoteTextSchedulePaymentBatch")]
  public class NoteTextSchedulePaymentBatch
  {
    /// <summary>
    /// The content of the note.
    /// </summary>
    [JsonProperty(PropertyName = "content")]
    public string Content { get; set; }

  }
}
