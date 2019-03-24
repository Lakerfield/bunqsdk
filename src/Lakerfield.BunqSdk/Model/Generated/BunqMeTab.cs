using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("BunqMeTab")]
  public class BunqMeTab
  {
    /// <summary>
    /// The bunq.me entry containing the payment information.
    /// </summary>
    [JsonProperty(PropertyName = "bunqme_tab_entry")]
    public BunqMeTabEntry BunqmeTabEntry { get; set; }

    /// <summary>
    /// The status of the bunq.me. Ignored in POST requests but can be used for cancelling the bunq.me by setting status as CANCELLED with a PUT request.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

  }
}
