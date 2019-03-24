using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("MonetaryAccountLight")]
  public class MonetaryAccountLight
  {
    /// <summary>
    /// The currency of the MonetaryAccountLight as an ISO 4217 formatted currency code.
    /// </summary>
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// The description of the MonetaryAccountLight. Defaults to 'bunq account'.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The daily spending limit Amount of the MonetaryAccountLight. Defaults to 1000 EUR. Currency must match the MonetaryAccountLight's currency. Limited to 10000 EUR.
    /// </summary>
    [JsonProperty(PropertyName = "daily_limit")]
    public Amount DailyLimit { get; set; }

    /// <summary>
    /// The UUID of the Avatar of the MonetaryAccountLight.
    /// </summary>
    [JsonProperty(PropertyName = "avatar_uuid")]
    public string AvatarUuid { get; set; }

    /// <summary>
    /// The status of the MonetaryAccountLight. Can be: ACTIVE, BLOCKED, CANCELLED or PENDING_REOPEN
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The sub-status of the MonetaryAccountLight providing extra information regarding the status. Will be NONE for ACTIVE or PENDING_REOPEN, COMPLETELY or ONLY_ACCEPTING_INCOMING for BLOCKED and REDEMPTION_INVOLUNTARY, REDEMPTION_VOLUNTARY or PERMANENT for CANCELLED.
    /// </summary>
    [JsonProperty(PropertyName = "sub_status")]
    public string SubStatus { get; set; }

    /// <summary>
    /// The reason for voluntarily cancelling (closing) the MonetaryAccountBank, can only be OTHER.
    /// </summary>
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// The optional free-form reason for voluntarily cancelling (closing) the MonetaryAccountBank. Can be any user provided message.
    /// </summary>
    [JsonProperty(PropertyName = "reason_description")]
    public string ReasonDescription { get; set; }

    /// <summary>
    /// The types of notifications that will result in a push notification or URL callback for this MonetaryAccountLight.
    /// </summary>
    [JsonProperty(PropertyName = "notification_filters")]
    public NotificationFilter[] NotificationFilters { get; set; }

    /// <summary>
    /// The settings of the MonetaryAccountLight.
    /// </summary>
    [JsonProperty(PropertyName = "setting")]
    public MonetaryAccountSetting Setting { get; set; }

    /// <summary>
    /// The id of the MonetaryAccountLight.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the MonetaryAccountLight's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the MonetaryAccountLight's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The Avatar of the MonetaryAccountLight.
    /// </summary>
    [JsonProperty(PropertyName = "avatar")]
    public Avatar Avatar { get; set; }

    /// <summary>
    /// Total Amount of money spent today. Timezone aware.
    /// </summary>
    [JsonProperty(PropertyName = "daily_spent")]
    public Amount DailySpent { get; set; }

    /// <summary>
    /// The current balance Amount of the MonetaryAccountLight.
    /// </summary>
    [JsonProperty(PropertyName = "balance")]
    public Amount Balance { get; set; }

    /// <summary>
    /// The Aliases for the MonetaryAccountLight.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public Pointer[] Alias { get; set; }

    /// <summary>
    /// The MonetaryAccountLight's public UUID.
    /// </summary>
    [JsonProperty(PropertyName = "public_uuid")]
    public string PublicUuid { get; set; }

    /// <summary>
    /// The id of the User who owns the MonetaryAccountLight.
    /// </summary>
    [JsonProperty(PropertyName = "user_id")]
    public int UserId { get; set; }

    /// <summary>
    /// The maximum balance Amount of the MonetaryAccountLight.
    /// </summary>
    [JsonProperty(PropertyName = "balance_maximum")]
    public Amount BalanceMaximum { get; set; }

    /// <summary>
    /// The amount of the monthly budget used.
    /// </summary>
    [JsonProperty(PropertyName = "budget_month_used")]
    public Amount BudgetMonthUsed { get; set; }

    /// <summary>
    /// The total amount of the monthly budget.
    /// </summary>
    [JsonProperty(PropertyName = "budget_month_maximum")]
    public Amount BudgetMonthMaximum { get; set; }

    /// <summary>
    /// The amount of the yearly budget used.
    /// </summary>
    [JsonProperty(PropertyName = "budget_year_used")]
    public Amount BudgetYearUsed { get; set; }

    /// <summary>
    /// The total amount of the yearly budget.
    /// </summary>
    [JsonProperty(PropertyName = "budget_year_maximum")]
    public Amount BudgetYearMaximum { get; set; }

    /// <summary>
    /// The amount of the yearly withdrawal budget used.
    /// </summary>
    [JsonProperty(PropertyName = "budget_withdrawal_year_used")]
    public Amount BudgetWithdrawalYearUsed { get; set; }

    /// <summary>
    /// The total amount of the yearly withdrawal budget.
    /// </summary>
    [JsonProperty(PropertyName = "budget_withdrawal_year_maximum")]
    public Amount BudgetWithdrawalYearMaximum { get; set; }

  }
}
