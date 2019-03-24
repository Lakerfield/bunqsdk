using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("NoteAttachmentBankSwitchServiceNetherlandsIncomingPaymentCreate")]
  public class NoteAttachmentBankSwitchServiceNetherlandsIncomingPaymentCreate
  {
    /// <summary>
    /// The id of the created item
    /// </summary>
    [JsonProperty(PropertyName = "Id")]
    public BunqId Id { get; set; }

  }
}
