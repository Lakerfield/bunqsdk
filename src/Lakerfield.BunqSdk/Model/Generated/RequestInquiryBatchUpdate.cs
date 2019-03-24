using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("RequestInquiryBatchUpdate")]
  public class RequestInquiryBatchUpdate
  {
    /// <summary>
    /// The id of the created item
    /// </summary>
    [JsonProperty(PropertyName = "Id")]
    public BunqId Id { get; set; }

  }
}
