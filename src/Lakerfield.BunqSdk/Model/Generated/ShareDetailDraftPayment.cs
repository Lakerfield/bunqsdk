using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("ShareDetailDraftPayment")]
  public class ShareDetailDraftPayment
  {
    /// <summary>
    /// If set to true, the invited user will be able to make draft payments from the shared account.
    /// </summary>
    [JsonProperty(PropertyName = "make_draft_payments")]
    public bool MakeDraftPayments { get; set; }

    /// <summary>
    /// If set to true, the invited user will be able to view the account balance.
    /// </summary>
    [JsonProperty(PropertyName = "view_balance")]
    public bool ViewBalance { get; set; }

    /// <summary>
    /// If set to true, the invited user will be able to view events from before the share was active.
    /// </summary>
    [JsonProperty(PropertyName = "view_old_events")]
    public bool ViewOldEvents { get; set; }

    /// <summary>
    /// If set to true, the invited user will be able to view events starting from the time the share became active.
    /// </summary>
    [JsonProperty(PropertyName = "view_new_events")]
    public bool ViewNewEvents { get; set; }

  }
}
