using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("BunqMeTabListing")]
  public class BunqMeTabListing
  {
    /// <summary>
    /// The id of the created bunq.me.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp when the bunq.me was created.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp when the bunq.me was last updated.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The timestamp of when the bunq.me expired or will expire.
    /// </summary>
    [JsonProperty(PropertyName = "time_expiry")]
    public string TimeExpiry { get; set; }

    /// <summary>
    /// The id of the MonetaryAccount the bunq.me was sent from.
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_id")]
    public int MonetaryAccountId { get; set; }

    /// <summary>
    /// The status of the bunq.me. Can be WAITING_FOR_PAYMENT, CANCELLED or EXPIRED.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The url that points to the bunq.me page.
    /// </summary>
    [JsonProperty(PropertyName = "bunqme_tab_share_url")]
    public string BunqmeTabShareUrl { get; set; }

    /// <summary>
    /// The bunq.me entry containing the payment information.
    /// </summary>
    [JsonProperty(PropertyName = "bunqme_tab_entry")]
    public BunqMeTabEntry BunqmeTabEntry { get; set; }

    /// <summary>
    /// The list of bunq.me result Inquiries successfully made and paid.
    /// </summary>
    [JsonProperty(PropertyName = "result_inquiries")]
    public BunqMeTabResultInquiry[] ResultInquiries { get; set; }

  }
}
