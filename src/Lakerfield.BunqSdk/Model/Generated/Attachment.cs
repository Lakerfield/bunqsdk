using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("Attachment")]
  public class Attachment
  {
    /// <summary>
    /// The description of the attachment.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The content type of the attachment's file.
    /// </summary>
    [JsonProperty(PropertyName = "content_type")]
    public string ContentType { get; set; }

  }
}
