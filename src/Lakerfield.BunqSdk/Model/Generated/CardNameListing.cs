using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CardNameListing")]
  public class CardNameListing
  {
    /// <summary>
    /// All possible variations (of suitable length) of user's legal name for the debit card.
    /// </summary>
    [JsonProperty(PropertyName = "possible_card_name_array")]
    public string[] PossibleCardNameArray { get; set; }

  }
}
