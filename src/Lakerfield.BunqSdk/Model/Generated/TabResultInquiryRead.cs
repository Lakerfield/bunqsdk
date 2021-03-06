using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TabResultInquiryRead")]
  public class TabResultInquiryRead
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

  }
}
