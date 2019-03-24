using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CardBatch")]
  public class CardBatch
  {
    /// <summary>
    /// The cards that need to be updated.
    /// </summary>
    [JsonProperty(PropertyName = "cards")]
    public CardBatchEntry[] Cards { get; set; }

  }
}
