using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("DraftPaymentCreate")]
  public class DraftPaymentCreate
  {
    /// <summary>
    /// The id of the created DrafPayment.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
