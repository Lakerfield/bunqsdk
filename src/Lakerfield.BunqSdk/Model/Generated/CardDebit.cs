using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CardDebit")]
  public class CardDebit
  {
    /// <summary>
    /// The second line of text on the card, used as name/description for it. It can contain at most 17 characters and it can be empty.
    /// </summary>
    [JsonProperty(PropertyName = "second_line")]
    public string SecondLine { get; set; }

    /// <summary>
    /// The user's name as it will be on the card. Check 'card-name' for the available card names for a user.
    /// </summary>
    [JsonProperty(PropertyName = "name_on_card")]
    public string NameOnCard { get; set; }

    /// <summary>
    /// The pointer to the monetary account that will be connected at first with the card. Its IBAN code is also the one that will be printed on the card itself. The pointer must be of type IBAN.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public Pointer Alias { get; set; }

    /// <summary>
    /// The type of card to order. Can be MAESTRO or MASTERCARD.
    /// </summary>
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Array of Types, PINs, account IDs assigned to the card.
    /// </summary>
    [JsonProperty(PropertyName = "pin_code_assignment")]
    public CardPinAssignment[] PinCodeAssignment { get; set; }

    /// <summary>
    /// ID of the MA to be used as fallback for this card if insufficient balance. Fallback account is removed if not supplied.
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_id_fallback")]
    public int MonetaryAccountIdFallback { get; set; }

  }
}
