using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("BunqMeTabResultResponse")]
  public class BunqMeTabResultResponse
  {
    /// <summary>
    /// The payment made for the bunq.me tab.
    /// </summary>
    [JsonProperty(PropertyName = "payment")]
    public Payment Payment { get; set; }

  }
}
