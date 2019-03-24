using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("WhitelistResultViewAnchoredObject")]
  public class WhitelistResultViewAnchoredObject
  {
    /// <summary>
    /// The ID of the whitelist entry.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The RequestResponse object
    /// </summary>
    [JsonProperty(PropertyName = "requestResponse")]
    public RequestResponse Requestresponse { get; set; }

    /// <summary>
    /// The DraftPayment object
    /// </summary>
    [JsonProperty(PropertyName = "draftPayment")]
    public DraftPayment Draftpayment { get; set; }

  }
}
