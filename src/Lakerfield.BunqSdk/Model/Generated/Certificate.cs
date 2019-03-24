using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("Certificate")]
  public class Certificate
  {
    /// <summary>
    /// A single certificate in the chain in .PEM format.
    /// </summary>
    [JsonProperty(PropertyName = "certificate")]
    public string Value { get; set; }

  }
}
