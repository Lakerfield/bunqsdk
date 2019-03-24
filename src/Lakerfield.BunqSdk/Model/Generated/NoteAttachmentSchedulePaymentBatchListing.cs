using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("NoteAttachmentSchedulePaymentBatchListing")]
  public class NoteAttachmentSchedulePaymentBatchListing
  {
    /// <summary>
    /// The id of the note.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the note's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the note's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The label of the user who created this note.
    /// </summary>
    [JsonProperty(PropertyName = "label_user_creator")]
    public LabelUser LabelUserCreator { get; set; }

    /// <summary>
    /// Optional description of the attachment.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The attachment attached to the note.
    /// </summary>
    [JsonProperty(PropertyName = "attachment")]
    public AttachmentMonetaryAccountPayment[] Attachment { get; set; }

  }
}
