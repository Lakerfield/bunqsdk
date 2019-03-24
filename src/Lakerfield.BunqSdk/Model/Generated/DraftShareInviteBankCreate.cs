using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("DraftShareInviteBankCreate")]
  public class DraftShareInviteBankCreate
  {
    /// <summary>
    /// The id of the newly created draft share invite.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
