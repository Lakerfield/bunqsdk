using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("AttachmentPublicCreate")]
  public class AttachmentPublicCreate
  {
    /// <summary>
    /// The id of the created item
    /// </summary>
    [JsonProperty(PropertyName = "Id")]
    public BunqId Id { get; set; }

  }
}
