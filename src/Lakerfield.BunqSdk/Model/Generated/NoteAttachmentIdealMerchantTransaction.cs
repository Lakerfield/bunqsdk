using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("NoteAttachmentIdealMerchantTransaction")]
  public class NoteAttachmentIdealMerchantTransaction
  {
    /// <summary>
    /// Optional description of the attachment.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The reference to the uploaded file to attach to this note.
    /// </summary>
    [JsonProperty(PropertyName = "attachment_id")]
    public int AttachmentId { get; set; }

  }
}
