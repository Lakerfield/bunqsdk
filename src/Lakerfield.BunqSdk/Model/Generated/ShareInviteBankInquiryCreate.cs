using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("ShareInviteBankInquiryCreate")]
  public class ShareInviteBankInquiryCreate
  {
    /// <summary>
    /// The id of the newly created share invite.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
