using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("RewardRecipientListing")]
  public class RewardRecipientListing
  {
    /// <summary>
    /// The id of the reward.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The time the reward was created.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The time the reward was last updated.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The status of the reward.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The subStatus of the reward.
    /// </summary>
    [JsonProperty(PropertyName = "sub_status")]
    public string SubStatus { get; set; }

    /// <summary>
    /// The type of the reward.
    /// </summary>
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The alias of the other user eligible for the reward award.
    /// </summary>
    [JsonProperty(PropertyName = "counterparty_alias")]
    public LabelUser CounterpartyAlias { get; set; }

    /// <summary>
    /// The amount that will be/was awarded as reward for the reward.
    /// </summary>
    [JsonProperty(PropertyName = "amount_reward")]
    public Amount AmountReward { get; set; }

  }
}
