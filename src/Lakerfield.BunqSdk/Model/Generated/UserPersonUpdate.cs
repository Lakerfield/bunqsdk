using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("UserPersonUpdate")]
  public class UserPersonUpdate
  {
    /// <summary>
    /// The id of the modified person object.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
