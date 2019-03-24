using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("DraftPaymentUpdate")]
  public class DraftPaymentUpdate
  {
    /// <summary>
    /// The id of the created DrafPayment.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
