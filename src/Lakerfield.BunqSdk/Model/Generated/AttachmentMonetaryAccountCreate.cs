using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("AttachmentMonetaryAccountCreate")]
  public class AttachmentMonetaryAccountCreate
  {
    /// <summary>
    /// The ID of the attachment created.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
