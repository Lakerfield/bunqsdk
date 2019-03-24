using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("BunqMeTabResultInquiry")]
  public class BunqMeTabResultInquiry
  {
    /// <summary>
    /// The payment made for the Tab.
    /// </summary>
    [JsonProperty(PropertyName = "payment")]
    public Payment Payment { get; set; }

    /// <summary>
    /// The Id of the bunq.me tab that this BunqMeTabResultInquiry belongs to.
    /// </summary>
    [JsonProperty(PropertyName = "bunq_me_tab_id")]
    public int BunqMeTabId { get; set; }

  }
}
