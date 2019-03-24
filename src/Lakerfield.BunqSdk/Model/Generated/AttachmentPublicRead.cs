using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("AttachmentPublicRead")]
  public class AttachmentPublicRead
  {
    /// <summary>
    /// The UUID of the attachment.
    /// </summary>
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// The timestamp of the attachment's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the attachment's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The attachment.
    /// </summary>
    [JsonProperty(PropertyName = "attachment")]
    public Attachment Attachment { get; set; }

  }
}
