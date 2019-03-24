using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TabResultResponse")]
  public class TabResultResponse
  {
    /// <summary>
    /// The Tab details.
    /// </summary>
    [JsonProperty(PropertyName = "tab")]
    public Tab Tab { get; set; }

    /// <summary>
    /// The payment made for the Tab.
    /// </summary>
    [JsonProperty(PropertyName = "payment")]
    public Payment Payment { get; set; }

    /// <summary>
    /// The reference to the object used for split the bill. Can be RequestInquiry or RequestInquiryBatch
    /// </summary>
    [JsonProperty(PropertyName = "request_reference_split_the_bill")]
    public RequestInquiryReference[] RequestReferenceSplitTheBill { get; set; }

  }
}
