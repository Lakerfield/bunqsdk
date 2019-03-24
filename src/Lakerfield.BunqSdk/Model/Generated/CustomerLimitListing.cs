using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CustomerLimitListing")]
  public class CustomerLimitListing
  {
    /// <summary>
    /// The limit of monetary accounts.
    /// </summary>
    [JsonProperty(PropertyName = "limit_monetary_account")]
    public int LimitMonetaryAccount { get; set; }

    /// <summary>
    /// The amount of additional monetary accounts you can create.
    /// </summary>
    [JsonProperty(PropertyName = "limit_monetary_account_remaining")]
    public int LimitMonetaryAccountRemaining { get; set; }

    /// <summary>
    /// The limit of Maestro cards.
    /// </summary>
    [JsonProperty(PropertyName = "limit_card_debit_maestro")]
    public int LimitCardDebitMaestro { get; set; }

    /// <summary>
    /// The limit of MasterCard cards.
    /// </summary>
    [JsonProperty(PropertyName = "limit_card_debit_mastercard")]
    public int LimitCardDebitMastercard { get; set; }

    /// <summary>
    /// The limit of wildcards, e.g. Maestro or MasterCard cards.
    /// </summary>
    [JsonProperty(PropertyName = "limit_card_debit_wildcard")]
    public int LimitCardDebitWildcard { get; set; }

    /// <summary>
    /// The limit of free replacement cards.
    /// </summary>
    [JsonProperty(PropertyName = "limit_card_debit_replacement")]
    public int LimitCardDebitReplacement { get; set; }

    /// <summary>
    /// The number of "PREMIUM_LIMITED" invites the user has remaining.
    /// </summary>
    [JsonProperty(PropertyName = "limit_invite_user_premium_limited")]
    public int LimitInviteUserPremiumLimited { get; set; }

    /// <summary>
    /// The maximum amount a user is allowed to spend in a month.
    /// </summary>
    [JsonProperty(PropertyName = "limit_amount_monthly")]
    public Amount LimitAmountMonthly { get; set; }

    /// <summary>
    /// The amount the user has spent in the last month.
    /// </summary>
    [JsonProperty(PropertyName = "spent_amount_monthly")]
    public Amount SpentAmountMonthly { get; set; }

  }
}
