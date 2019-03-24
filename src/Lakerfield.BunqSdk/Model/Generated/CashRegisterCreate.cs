using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CashRegisterCreate")]
  public class CashRegisterCreate
  {
    /// <summary>
    /// The id of the created CashRegister.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
