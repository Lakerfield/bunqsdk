using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CashRegisterUpdate")]
  public class CashRegisterUpdate
  {
    /// <summary>
    /// The id of the updated CashRegister.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
