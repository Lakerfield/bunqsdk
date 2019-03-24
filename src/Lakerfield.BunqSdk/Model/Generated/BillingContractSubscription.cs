using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("BillingContractSubscription")]
  public class BillingContractSubscription
  {
    /// <summary>
    /// The subscription type of the user. Can be one of PERSON_SUPER_LIGHT_V1, PERSON_LIGHT_V1, PERSON_MORE_V1, PERSON_FREE_V1, PERSON_PREMIUM_V1, COMPANY_V1, or COMPANY_V2.
    /// </summary>
    [JsonProperty(PropertyName = "subscription_type")]
    public string SubscriptionType { get; set; }

    /// <summary>
    /// The id of the billing contract.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp when the billing contract was made.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp when the billing contract was last updated.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The date from when the billing contract is valid.
    /// </summary>
    [JsonProperty(PropertyName = "contract_date_start")]
    public string ContractDateStart { get; set; }

    /// <summary>
    /// The date until when the billing contract is valid.
    /// </summary>
    [JsonProperty(PropertyName = "contract_date_end")]
    public string ContractDateEnd { get; set; }

    /// <summary>
    /// The version of the billing contract.
    /// </summary>
    [JsonProperty(PropertyName = "contract_version")]
    public int ContractVersion { get; set; }

    /// <summary>
    /// The subscription type the user will have after a subscription downgrade. Will be null if downgrading is not possible.
    /// </summary>
    [JsonProperty(PropertyName = "subscription_type_downgrade")]
    public string SubscriptionTypeDowngrade { get; set; }

    /// <summary>
    /// The subscription status.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The subscription substatus.
    /// </summary>
    [JsonProperty(PropertyName = "sub_status")]
    public string SubStatus { get; set; }

  }
}
