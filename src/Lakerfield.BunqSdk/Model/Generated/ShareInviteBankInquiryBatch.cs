using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("ShareInviteBankInquiryBatch")]
  public class ShareInviteBankInquiryBatch
  {
    /// <summary>
    /// The list of share invite bank inquiries that were made.
    /// </summary>
    [JsonProperty(PropertyName = "share_invite_bank_inquiries")]
    public ShareInviteBankInquiry[] ShareInviteBankInquiries { get; set; }

    /// <summary>
    /// The LabelMonetaryAccount containing the public information of this share invite inquiry batch.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public LabelMonetaryAccount Alias { get; set; }

  }
}
