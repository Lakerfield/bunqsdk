using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("RequestInquiryReference")]
  public class RequestInquiryReference
  {
    /// <summary>
    /// The type of request inquiry. Can be RequestInquiry or RequestInquiryBatch.
    /// </summary>
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The id of the request inquiry (batch).
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
