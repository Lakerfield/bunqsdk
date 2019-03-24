using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("Pointer")]
  public class Pointer
  {
    /// <summary>
    /// The alias type, can be: EMAIL|PHONE_NUMBER|IBAN.
    /// </summary>
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The alias value.
    /// </summary>
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// The alias name.
    /// </summary>
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

  }
}
