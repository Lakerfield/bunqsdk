using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("NoteTextScheduleInstanceCreate")]
  public class NoteTextScheduleInstanceCreate
  {
    /// <summary>
    /// The id of the created item
    /// </summary>
    [JsonProperty(PropertyName = "Id")]
    public BunqId Id { get; set; }

  }
}
