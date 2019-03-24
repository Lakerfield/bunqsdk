using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("NoteTextRequestInquiryBatch")]
  public class NoteTextRequestInquiryBatch
  {
    /// <summary>
    /// The content of the note.
    /// </summary>
    [JsonProperty(PropertyName = "content")]
    public string Content { get; set; }

  }
}
