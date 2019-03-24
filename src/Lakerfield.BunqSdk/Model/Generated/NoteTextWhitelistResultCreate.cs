using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("NoteTextWhitelistResultCreate")]
  public class NoteTextWhitelistResultCreate
  {
    /// <summary>
    /// The id of the created item
    /// </summary>
    [JsonProperty(PropertyName = "Id")]
    public BunqId Id { get; set; }

  }
}
