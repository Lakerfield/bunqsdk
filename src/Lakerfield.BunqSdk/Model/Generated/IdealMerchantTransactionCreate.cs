using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("IdealMerchantTransactionCreate")]
  public class IdealMerchantTransactionCreate
  {
    /// <summary>
    /// The id of the created item
    /// </summary>
    [JsonProperty(PropertyName = "Id")]
    public BunqId Id { get; set; }

  }
}
