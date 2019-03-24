using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("RequestInquiryCreate")]
  public class RequestInquiryCreate
  {
    /// <summary>
    /// The id of the created RequestInquiry.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
