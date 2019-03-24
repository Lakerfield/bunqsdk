using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("NoteTextScheduleInstance")]
  public class NoteTextScheduleInstance
  {
    /// <summary>
    /// The content of the note.
    /// </summary>
    [JsonProperty(PropertyName = "content")]
    public string Content { get; set; }

  }
}
