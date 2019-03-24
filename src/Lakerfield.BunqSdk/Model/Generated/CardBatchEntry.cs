using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CardBatchEntry")]
  public class CardBatchEntry
  {
    /// <summary>
    /// The ID of the card that needs to be updated.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The activation code required to set status to ACTIVE initially. Can only set status to ACTIVE using activation code when order_status is ACCEPTED_FOR_PRODUCTION and status is DEACTIVATED.
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
    /// DEPRECATED: The limits to define for the card, among CARD_LIMIT_ATM and CARD_LIMIT_POS_ICC. All the limits must be provided on update.
    /// </summary>
    [JsonProperty(PropertyName = "limit")]
    public CardLimit[] Limit { get; set; }

    /// <summary>
    /// The countries for which to grant (temporary) permissions to use the card.
    /// </summary>
    [JsonProperty(PropertyName = "country_permission")]
    public CardCountryPermission[] CountryPermission { get; set; }

    /// <summary>
    /// ID of the MA to be used as fallback for this card if insufficient balance. Fallback account is removed if not supplied.
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_id_fallback")]
    public int MonetaryAccountIdFallback { get; set; }

  }
}
