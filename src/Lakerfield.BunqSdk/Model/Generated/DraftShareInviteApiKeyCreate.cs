using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("DraftShareInviteApiKeyCreate")]
  public class DraftShareInviteApiKeyCreate
  {
    /// <summary>
    /// The id of the newly created draft share invite.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
