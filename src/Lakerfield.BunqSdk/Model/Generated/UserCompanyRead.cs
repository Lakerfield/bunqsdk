using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("UserCompanyRead")]
  public class UserCompanyRead
  {
    /// <summary>
    /// The id of the modified company.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the company object's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the company object's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The company's public UUID.
    /// </summary>
    [JsonProperty(PropertyName = "public_uuid")]
    public string PublicUuid { get; set; }

    /// <summary>
    /// The company name.
    /// </summary>
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The company's display name.
    /// </summary>
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// The company's public nick name.
    /// </summary>
    [JsonProperty(PropertyName = "public_nick_name")]
    public string PublicNickName { get; set; }

    /// <summary>
    /// The aliases of the account.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public Pointer[] Alias { get; set; }

    /// <summary>
    /// The company's chamber of commerce number.
    /// </summary>
    [JsonProperty(PropertyName = "chamber_of_commerce_number")]
    public string ChamberOfCommerceNumber { get; set; }

    /// <summary>
    /// The company's legal form.
    /// </summary>
    [JsonProperty(PropertyName = "legal_form")]
    public string LegalForm { get; set; }

    /// <summary>
    /// The type of business entity.
    /// </summary>
    [JsonProperty(PropertyName = "type_of_business_entity")]
    public string TypeOfBusinessEntity { get; set; }

    /// <summary>
    /// The sector of industry.
    /// </summary>
    [JsonProperty(PropertyName = "sector_of_industry")]
    public string SectorOfIndustry { get; set; }

    /// <summary>
    /// The company's other bank account IBAN, through which we verify it.
    /// </summary>
    [JsonProperty(PropertyName = "counter_bank_iban")]
    public string CounterBankIban { get; set; }

    /// <summary>
    /// The company's avatar.
    /// </summary>
    [JsonProperty(PropertyName = "avatar")]
    public Avatar Avatar { get; set; }

    /// <summary>
    /// The company's main address.
    /// </summary>
    [JsonProperty(PropertyName = "address_main")]
    public Address AddressMain { get; set; }

    /// <summary>
    /// The company's postal address.
    /// </summary>
    [JsonProperty(PropertyName = "address_postal")]
    public Address AddressPostal { get; set; }

    /// <summary>
    /// The version of the terms of service accepted by the user.
    /// </summary>
    [JsonProperty(PropertyName = "version_terms_of_service")]
    public string VersionTermsOfService { get; set; }

    /// <summary>
    /// The existing bunq user alias for the company's director.
    /// </summary>
    [JsonProperty(PropertyName = "director_alias")]
    public LabelUser DirectorAlias { get; set; }

    /// <summary>
    /// The person's preferred language. Formatted as a ISO 639-1 language code plus a ISO 3166-1 alpha-2 country code, seperated by an underscore.
    /// </summary>
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// The country as an ISO 3166-1 alpha-2 country code..
    /// </summary>
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// The person's preferred region. Formatted as a ISO 639-1 language code plus a ISO 3166-1 alpha-2 country code, seperated by an underscore.
    /// </summary>
    [JsonProperty(PropertyName = "region")]
    public string Region { get; set; }

    /// <summary>
    /// The names of the company's ultimate beneficiary owners. Minimum zero, maximum four.
    /// </summary>
    [JsonProperty(PropertyName = "ubo")]
    public Ubo[] Ubo { get; set; }

    /// <summary>
    /// The user status. Can be: ACTIVE, SIGNUP, RECOVERY.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The user sub-status. Can be: NONE, FACE_RESET, APPROVAL, APPROVAL_DIRECTOR, APPROVAL_PARENT, APPROVAL_SUPPORT, COUNTER_IBAN, IDEAL or SUBMIT.
    /// </summary>
    [JsonProperty(PropertyName = "sub_status")]
    public string SubStatus { get; set; }

    /// <summary>
    /// The setting for the session timeout of the company in seconds.
    /// </summary>
    [JsonProperty(PropertyName = "session_timeout")]
    public int SessionTimeout { get; set; }

    /// <summary>
    /// Card ids used for centralized card limits.
    /// </summary>
    [JsonProperty(PropertyName = "card_ids")]
    public BunqId[] CardIds { get; set; }

    /// <summary>
    /// The centralized limits for user's cards.
    /// </summary>
    [JsonProperty(PropertyName = "card_limits")]
    public CardLimit[] CardLimits { get; set; }

    /// <summary>
    /// The amount the company can pay in the session without asking for credentials.
    /// </summary>
    [JsonProperty(PropertyName = "daily_limit_without_confirmation_login")]
    public Amount DailyLimitWithoutConfirmationLogin { get; set; }

    /// <summary>
    /// The types of notifications that will result in a push notification or URL callback for this UserCompany.
    /// </summary>
    [JsonProperty(PropertyName = "notification_filters")]
    public NotificationFilter[] NotificationFilters { get; set; }

    /// <summary>
    /// The customer profile of the company.
    /// </summary>
    [JsonProperty(PropertyName = "customer")]
    public Customer Customer { get; set; }

    /// <summary>
    /// The customer limits of the company.
    /// </summary>
    [JsonProperty(PropertyName = "customer_limit")]
    public CustomerLimit CustomerLimit { get; set; }

    /// <summary>
    /// The subscription of the company.
    /// </summary>
    [JsonProperty(PropertyName = "billing_contract")]
    public BillingContractSubscription[] BillingContract { get; set; }

  }
}
