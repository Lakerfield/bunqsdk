using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("BudgetRestriction")]
  public class BudgetRestriction
  {
    /// <summary>
    /// The amount of the budget given to the invited user.
    /// </summary>
    [JsonProperty(PropertyName = "amount")]
    public Amount Amount { get; set; }

    /// <summary>
    /// The duration for a budget restriction. Valid values are DAILY, WEEKLY, MONTHLY, YEARLY.
    /// </summary>
    [JsonProperty(PropertyName = "frequency")]
    public string Frequency { get; set; }

  }
}
