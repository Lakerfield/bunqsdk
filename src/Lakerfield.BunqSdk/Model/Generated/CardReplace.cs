using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CardReplace")]
  public class CardReplace
  {
    /// <summary>
    /// The user's name as it will be on the card. Check 'card-name' for the available card names for a user.
    /// </summary>
    [JsonProperty(PropertyName = "name_on_card")]
    public string NameOnCard { get; set; }

    /// <summary>
    /// The plaintext pin code. Requests require encryption to be enabled.
    /// </summary>
    [JsonProperty(PropertyName = "pin_code")]
    public string PinCode { get; set; }

    /// <summary>
    /// The second line on the card.
    /// </summary>
    [JsonProperty(PropertyName = "second_line")]
    public string SecondLine { get; set; }

  }
}
