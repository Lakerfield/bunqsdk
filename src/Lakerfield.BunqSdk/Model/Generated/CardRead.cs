using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CardRead")]
  public class CardRead
  {
    /// <summary>
    /// The id of the card.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the card's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the card's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The public UUID of the card.
    /// </summary>
    [JsonProperty(PropertyName = "public_uuid")]
    public string PublicUuid { get; set; }

    /// <summary>
    /// The type of the card. Can be MAESTRO, MASTERCARD.
    /// </summary>
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The sub-type of the card.
    /// </summary>
    [JsonProperty(PropertyName = "sub_type")]
    public string SubType { get; set; }

    /// <summary>
    /// The second line of text on the card
    /// </summary>
    [JsonProperty(PropertyName = "second_line")]
    public string SecondLine { get; set; }

    /// <summary>
    /// The status to set for the card. Can be ACTIVE, DEACTIVATED, LOST, STOLEN, CANCELLED, EXPIRED or PIN_TRIES_EXCEEDED.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The sub-status of the card. Can be NONE or REPLACED.
    /// </summary>
    [JsonProperty(PropertyName = "sub_status")]
    public string SubStatus { get; set; }

    /// <summary>
    /// The order status of the card. Can be CARD_UPDATE_REQUESTED, CARD_UPDATE_SENT, CARD_UPDATE_ACCEPTED, ACCEPTED_FOR_PRODUCTION or DELIVERED_TO_CUSTOMER.
    /// </summary>
    [JsonProperty(PropertyName = "order_status")]
    public string OrderStatus { get; set; }

    /// <summary>
    /// Expiry date of the card.
    /// </summary>
    [JsonProperty(PropertyName = "expiry_date")]
    public string ExpiryDate { get; set; }

    /// <summary>
    /// The user's name on the card.
    /// </summary>
    [JsonProperty(PropertyName = "name_on_card")]
    public string NameOnCard { get; set; }

    /// <summary>
    /// The last 4 digits of the PAN of the card.
    /// </summary>
    [JsonProperty(PropertyName = "primary_account_number_four_digit")]
    public string PrimaryAccountNumberFourDigit { get; set; }

    /// <summary>
    /// Array of PANs, status, description and account id for online cards.
    /// </summary>
    [JsonProperty(PropertyName = "primary_account_numbers_virtual")]
    public CardVirtualPrimaryAccountNumber[] PrimaryAccountNumbersVirtual { get; set; }

    /// <summary>
    /// The spending limit for the card.
    /// </summary>
    [JsonProperty(PropertyName = "card_limit")]
    public Amount CardLimit { get; set; }

    /// <summary>
    /// The ATM spending limit for the card.
    /// </summary>
    [JsonProperty(PropertyName = "card_limit_atm")]
    public Amount CardLimitAtm { get; set; }

    /// <summary>
    /// DEPRECATED: The limits to define for the card, among CARD_LIMIT_CONTACTLESS, CARD_LIMIT_ATM, CARD_LIMIT_DIPPING and CARD_LIMIT_POS_ICC (e.g. 25 EUR for CARD_LIMIT_CONTACTLESS)
    /// </summary>
    [JsonProperty(PropertyName = "limit")]
    public CardLimit[] Limit { get; set; }

    /// <summary>
    /// The countries for which to grant (temporary) permissions to use the card.
    /// </summary>
    [JsonProperty(PropertyName = "country_permission")]
    public CardCountryPermission[] CountryPermission { get; set; }

    /// <summary>
    /// The monetary account this card was ordered on and the label user that owns the card.
    /// </summary>
    [JsonProperty(PropertyName = "label_monetary_account_ordered")]
    public LabelMonetaryAccount LabelMonetaryAccountOrdered { get; set; }

    /// <summary>
    /// The monetary account that this card is currently linked to and the label user viewing it.
    /// </summary>
    [JsonProperty(PropertyName = "label_monetary_account_current")]
    public LabelMonetaryAccount LabelMonetaryAccountCurrent { get; set; }

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

    /// <summary>
    /// The country that is domestic to the card. Defaults to country of residence of user.
    /// </summary>
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

  }
}
