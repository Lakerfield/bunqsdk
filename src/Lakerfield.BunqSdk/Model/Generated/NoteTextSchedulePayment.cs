using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("NoteTextSchedulePayment")]
  public class NoteTextSchedulePayment
  {
    /// <summary>
    /// The content of the note.
    /// </summary>
    [JsonProperty(PropertyName = "content")]
    public string Content { get; set; }

  }
}
