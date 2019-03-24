using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CardBatchCreate")]
  public class CardBatchCreate
  {
    /// <summary>
    /// The ids of the cards that have been updated.
    /// </summary>
    [JsonProperty(PropertyName = "updated_card_ids")]
    public BunqId[] UpdatedCardIds { get; set; }

  }
}
