using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("Issuer")]
  public class Issuer
  {
    /// <summary>
    /// The BIC code.
    /// </summary>
    [JsonProperty(PropertyName = "bic")]
    public string Bic { get; set; }

    /// <summary>
    /// The name of the bank.
    /// </summary>
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

  }
}
