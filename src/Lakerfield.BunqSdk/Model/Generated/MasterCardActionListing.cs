using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("MasterCardActionListing")]
  public class MasterCardActionListing
  {
    /// <summary>
    /// The id of the MastercardAction.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The id of the monetary account this action links to.
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_id")]
    public int MonetaryAccountId { get; set; }

    /// <summary>
    /// The id of the card this action links to.
    /// </summary>
    [JsonProperty(PropertyName = "card_id")]
    public int CardId { get; set; }

    /// <summary>
    /// The amount of the transaction in local currency.
    /// </summary>
    [JsonProperty(PropertyName = "amount_local")]
    public Amount AmountLocal { get; set; }

    /// <summary>
    /// The amount of the transaction in local currency.
    /// </summary>
    [JsonProperty(PropertyName = "amount_converted")]
    public Amount AmountConverted { get; set; }

    /// <summary>
    /// The amount of the transaction in the monetary account's currency.
    /// </summary>
    [JsonProperty(PropertyName = "amount_billing")]
    public Amount AmountBilling { get; set; }

    /// <summary>
    /// The original amount in local currency.
    /// </summary>
    [JsonProperty(PropertyName = "amount_original_local")]
    public Amount AmountOriginalLocal { get; set; }

    /// <summary>
    /// The original amount in the monetary account's currency.
    /// </summary>
    [JsonProperty(PropertyName = "amount_original_billing")]
    public Amount AmountOriginalBilling { get; set; }

    /// <summary>
    /// The fee amount as charged by the merchant, if applicable.
    /// </summary>
    [JsonProperty(PropertyName = "amount_fee")]
    public Amount AmountFee { get; set; }

    /// <summary>
    /// The response code by which authorised transaction can be identified as authorised by bunq.
    /// </summary>
    [JsonProperty(PropertyName = "card_authorisation_id_response")]
    public string CardAuthorisationIdResponse { get; set; }

    /// <summary>
    /// Why the transaction was denied, if it was denied, or just ALLOWED.
    /// </summary>
    [JsonProperty(PropertyName = "decision")]
    public string Decision { get; set; }

    /// <summary>
    /// Empty if allowed, otherwise a textual explanation of why it was denied.
    /// </summary>
    [JsonProperty(PropertyName = "decision_description")]
    public string DecisionDescription { get; set; }

    /// <summary>
    /// Empty if allowed, otherwise a textual explanation of why it was denied in user's language.
    /// </summary>
    [JsonProperty(PropertyName = "decision_description_translated")]
    public string DecisionDescriptionTranslated { get; set; }

    /// <summary>
    /// The description for this transaction to display.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The status in the authorisation process.
    /// </summary>
    [JsonProperty(PropertyName = "authorisation_status")]
    public string AuthorisationStatus { get; set; }

    /// <summary>
    /// The type of transaction that was delivered using the card.
    /// </summary>
    [JsonProperty(PropertyName = "authorisation_type")]
    public string AuthorisationType { get; set; }

    /// <summary>
    /// The type of entry mode the user used. Can be 'ATM', 'ICC', 'MAGNETIC_STRIPE' or 'E_COMMERCE'.
    /// </summary>
    [JsonProperty(PropertyName = "pan_entry_mode_user")]
    public string PanEntryModeUser { get; set; }

    /// <summary>
    /// The setlement status in the authorisation process.
    /// </summary>
    [JsonProperty(PropertyName = "settlement_status")]
    public string SettlementStatus { get; set; }

    /// <summary>
    /// The city where the message originates from as announced by the terminal.
    /// </summary>
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// The monetary account label of the account that this action is created for.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public LabelMonetaryAccount Alias { get; set; }

    /// <summary>
    /// The monetary account label of the counterparty.
    /// </summary>
    [JsonProperty(PropertyName = "counterparty_alias")]
    public LabelMonetaryAccount CounterpartyAlias { get; set; }

    /// <summary>
    /// The label of the card.
    /// </summary>
    [JsonProperty(PropertyName = "label_card")]
    public LabelCard LabelCard { get; set; }

    /// <summary>
    /// If this is a tokenisation action, this shows the status of the token.
    /// </summary>
    [JsonProperty(PropertyName = "token_status")]
    public string TokenStatus { get; set; }

    /// <summary>
    /// If this is a reservation, the moment the reservation will expire.
    /// </summary>
    [JsonProperty(PropertyName = "reservation_expiry_time")]
    public string ReservationExpiryTime { get; set; }

    /// <summary>
    /// The type of the limit applied to validate if this MasterCardAction was within the spending limits. The returned string matches the limit types as defined in the card endpoint.
    /// </summary>
    [JsonProperty(PropertyName = "applied_limit")]
    public string AppliedLimit { get; set; }

    /// <summary>
    /// Whether or not chat messages are allowed.
    /// </summary>
    [JsonProperty(PropertyName = "allow_chat")]
    public bool AllowChat { get; set; }

    /// <summary>
    /// The whitelist id for this mastercard action or null.
    /// </summary>
    [JsonProperty(PropertyName = "eligible_whitelist_id")]
    public int EligibleWhitelistId { get; set; }

    /// <summary>
    /// The secure code id for this mastercard action or null.
    /// </summary>
    [JsonProperty(PropertyName = "secure_code_id")]
    public int SecureCodeId { get; set; }

    /// <summary>
    /// The ID of the wallet provider as defined by MasterCard. 420 = bunq Android app with Tap&Pay; 103 = Apple Pay.
    /// </summary>
    [JsonProperty(PropertyName = "wallet_provider_id")]
    public string WalletProviderId { get; set; }

    /// <summary>
    /// The reference to the object used for split the bill. Can be RequestInquiry or RequestInquiryBatch
    /// </summary>
    [JsonProperty(PropertyName = "request_reference_split_the_bill")]
    public RequestInquiryReference[] RequestReferenceSplitTheBill { get; set; }

  }
}
