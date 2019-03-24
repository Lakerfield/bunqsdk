using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CardGeneratedCvc2")]
  public class CardGeneratedCvc2
  {
    /// <summary>
    /// The type of generated cvc2. Can be STATIC or GENERATED.
    /// </summary>
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

  }
}
