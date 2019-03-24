using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("ExportRibCreate")]
  public class ExportRibCreate
  {
    /// <summary>
    /// The id of the rib as created on the server.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
