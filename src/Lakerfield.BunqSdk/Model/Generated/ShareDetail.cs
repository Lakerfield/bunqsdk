using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("ShareDetail")]
  public class ShareDetail
  {
    /// <summary>
    /// The share details for a payment share. In the response 'payment' is replaced by 'ShareDetailPayment'.
    /// </summary>
    [JsonProperty(PropertyName = "payment")]
    public ShareDetailPayment Payment { get; set; }

    /// <summary>
    /// The share details for viewing a share. In the response 'read_only' is replaced by 'ShareDetailReadOnly'.
    /// </summary>
    [JsonProperty(PropertyName = "read_only")]
    public ShareDetailReadOnly ReadOnly { get; set; }

    /// <summary>
    /// The share details for a draft payment share. In the response 'draft_payment' is replaced by 'ShareDetailDraftPayment'.
    /// </summary>
    [JsonProperty(PropertyName = "draft_payment")]
    public ShareDetailDraftPayment DraftPayment { get; set; }

  }
}
