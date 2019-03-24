using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("Card")]
  public class Card
  {
    /// <summary>
    /// The plaintext pin code. Requests require encryption to be enabled.
    /// </summary>
    [JsonProperty(PropertyName = "pin_code")]
    public string PinCode { get; set; }

    /// <summary>
    /// DEPRECATED: Activate a card by setting status to ACTIVE when the order_status is ACCEPTED_FOR_PRODUCTION.
    /// </summary>
    [JsonProperty(PropertyName = "activation_code")]
    public string ActivationCode { get; set; }

    /// <summary>
    /// The status to set for the card. Can be ACTIVE, DEACTIVATED, LOST, STOLEN or CANCELLED, and can only be set to LOST/STOLEN/CANCELLED when order status is ACCEPTED_FOR_PRODUCTION/DELIVERED_TO_CUSTOMER/CARD_UPDATE_REQUESTED/CARD_UPDATE_SENT/CARD_UPDATE_ACCEPTED. Can only be set to DEACTIVATED after initial activation, i.e. order_status is DELIVERED_TO_CUSTOMER/CARD_UPDATE_REQUESTED/CARD_UPDATE_SENT/CARD_UPDATE_ACCEPTED. Mind that all the possible choices (apart from ACTIVE and DEACTIVATED) are permanent and cannot be changed after.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

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
    /// DEPRECATED: The limits to define for the card, among CARD_LIMIT_CONTACTLESS, CARD_LIMIT_ATM, CARD_LIMIT_DIPPING and CARD_LIMIT_POS_ICC (e.g. 25 EUR for CARD_LIMIT_CONTACTLESS). All the limits must be provided on update.
    /// </summary>
    [JsonProperty(PropertyName = "limit")]
    public CardLimit[] Limit { get; set; }

    /// <summary>
    /// DEPRECATED: Whether or not it is allowed to use the mag stripe for the card.
    /// </summary>
    [JsonProperty(PropertyName = "mag_stripe_permission")]
    public CardMagStripePermission MagStripePermission { get; set; }

    /// <summary>
    /// The countries for which to grant (temporary) permissions to use the card.
    /// </summary>
    [JsonProperty(PropertyName = "country_permission")]
    public CardCountryPermission[] CountryPermission { get; set; }

    /// <summary>
    /// Array of Types, PINs, account IDs assigned to the card.
    /// </summary>
    [JsonProperty(PropertyName = "pin_code_assignment")]
    public CardPinAssignment[] PinCodeAssignment { get; set; }

    /// <summary>
    /// Array of PANs, status, description and account id for online cards.
    /// </summary>
    [JsonProperty(PropertyName = "primary_account_numbers_virtual")]
    public CardVirtualPrimaryAccountNumber[] PrimaryAccountNumbersVirtual { get; set; }

    /// <summary>
    /// ID of the MA to be used as fallback for this card if insufficient balance. Fallback account is removed if not supplied.
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_id_fallback")]
    public int MonetaryAccountIdFallback { get; set; }

  }
}
