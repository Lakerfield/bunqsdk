using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("AttachmentMonetaryAccountPayment")]
  public class AttachmentMonetaryAccountPayment
  {
    /// <summary>
    /// The id of the attached Attachment.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The id of the MonetaryAccount this Attachment is attached from.
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_id")]
    public int MonetaryAccountId { get; set; }

  }
}
