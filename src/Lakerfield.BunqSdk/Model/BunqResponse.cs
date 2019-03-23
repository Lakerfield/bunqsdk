using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Lakerfield.BunqSdk.Model
{
  public class BunqResponse
  {
    public Dictionary<string, string> Headers { get; }
    private readonly JArray _array;

    public BunqResponse(JArray array, Dictionary<string, string> headers = null)
    {
      Headers = headers;
      _array = array;
    }

    public T Get<T>()
    {
      if (_array == null)
        return default(T);

      var attribute = typeof(T).GetCustomAttribute<BunqObjectAttribute>();
      if (attribute == null)
        throw new Exception("Cannot find BunqObjectAttribute");

      foreach (var token in _array)
      {
        if (token.Type != JTokenType.Object)
          continue;

        var response = (JObject)token;
        if (!response.TryGetValue(attribute.Name, out var result))
          continue;

        return result.ToObject<T>();
      }

      return default(T);
    }

  }


  [BunqObject("ApiKey")]
  public class ApiKey
  {
    [JsonProperty(PropertyName = "api_key")]
    public string Value { get; set; }
  }

  [BunqObject("ClientPublicKey")]
  public class ClientPublicKey
  {
    [JsonProperty(PropertyName = "client_public_key")]
    public string Value { get; set; }
  }

  [BunqObject("Id")]
  public class Id
  {
    [JsonProperty(PropertyName = "id")]
    public int Value { get; set; }
  }

  [BunqObject("Token")]
  public class Token
  {
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    [JsonProperty(PropertyName = "created")]
    public DateTime Created { get; set; }

    [JsonProperty(PropertyName = "updated")]
    public DateTime Updated { get; set; }

    [JsonProperty(PropertyName = "token")]
    public string Value { get; set; }
  }

  [BunqObject("ServerPublicKey")]
  public class ServerPublicKey
  {
    [JsonProperty(PropertyName = "server_public_key")]
    public string Value { get; set; }
  }

  [BunqObject("UserApiKey")]
  public class UserApiKey
  {
    /// <summary>
    /// The id of the user.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The timestamp of the user object's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the user object's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    ///// <summary>
    ///// The user who requested access.
    ///// </summary>
    //[JsonProperty(PropertyName = "requested_by_user")]
    //public UserApiKeyAnchoredUser RequestedByUser { get; set; }

    ///// <summary>
    ///// The user who granted access.
    ///// </summary>
    //[JsonProperty(PropertyName = "granted_by_user")]
    //public UserApiKeyAnchoredUser GrantedByUser { get; set; }

  }

  [BunqObject("UserPerson")]
  public class UserPerson
  {
    /// <summary>
    /// The company name.
    /// </summary>
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The company's public nick name.
    /// </summary>
    [JsonProperty(PropertyName = "public_nick_name")]
    public string PublicNickName { get; set; }

    /// <summary>
    /// The public UUID of the company's avatar.
    /// </summary>
    [JsonProperty(PropertyName = "avatar_uuid")]
    public string AvatarUuid { get; set; }

    ///// <summary>
    ///// The company's main address.
    ///// </summary>
    //[JsonProperty(PropertyName = "address_main")]
    //public Address AddressMain { get; set; }

    ///// <summary>
    ///// The company's postal address.
    ///// </summary>
    //[JsonProperty(PropertyName = "address_postal")]
    //public Address AddressPostal { get; set; }

    /// <summary>
    /// The person's preferred language. Formatted as a ISO 639-1 language code plus a ISO 3166-1 alpha-2 country
    /// code, seperated by an underscore.
    /// </summary>
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// The person's preferred region. Formatted as a ISO 639-1 language code plus a ISO 3166-1 alpha-2 country
    /// code, seperated by an underscore.
    /// </summary>
    [JsonProperty(PropertyName = "region")]
    public string Region { get; set; }

    /// <summary>
    /// The country as an ISO 3166-1 alpha-2 country code..
    /// </summary>
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    ///// <summary>
    ///// The names of the company's ultimate beneficiary owners. Minimum zero, maximum four.
    ///// </summary>
    //[JsonProperty(PropertyName = "ubo")]
    //public List<Ubo> Ubo { get; set; }

    /// <summary>
    /// The company's chamber of commerce number.
    /// </summary>
    [JsonProperty(PropertyName = "chamber_of_commerce_number")]
    public string ChamberOfCommerceNumber { get; set; }

    /// <summary>
    /// The user status. Can be: ACTIVE, SIGNUP, RECOVERY.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The user sub-status. Can be: NONE, FACE_RESET, APPROVAL, APPROVAL_DIRECTOR, APPROVAL_PARENT,
    /// APPROVAL_SUPPORT, COUNTER_IBAN, IDEAL or SUBMIT.
    /// </summary>
    [JsonProperty(PropertyName = "sub_status")]
    public string SubStatus { get; set; }

    /// <summary>
    /// The setting for the session timeout of the company in seconds.
    /// </summary>
    [JsonProperty(PropertyName = "session_timeout")]
    public int? SessionTimeout { get; set; }

    ///// <summary>
    ///// The amount the company can pay in the session without asking for credentials.
    ///// </summary>
    //[JsonProperty(PropertyName = "daily_limit_without_confirmation_login")]
    //public Amount DailyLimitWithoutConfirmationLogin { get; set; }

    ///// <summary>
    ///// The types of notifications that will result in a push notification or URL callback for this UserCompany.
    ///// </summary>
    //[JsonProperty(PropertyName = "notification_filters")]
    //public List<NotificationFilter> NotificationFilters { get; set; }

    /// <summary>
    /// The id of the modified company.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

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
    /// The company's display name.
    /// </summary>
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// The aliases of the account.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public List<Pointer> Alias { get; set; }

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

    ///// <summary>
    ///// The company's avatar.
    ///// </summary>
    //[JsonProperty(PropertyName = "avatar")]
    //public Avatar Avatar { get; set; }

    /// <summary>
    /// The version of the terms of service accepted by the user.
    /// </summary>
    [JsonProperty(PropertyName = "version_terms_of_service")]
    public string VersionTermsOfService { get; set; }

    ///// <summary>
    ///// The existing bunq user alias for the company's director.
    ///// </summary>
    //[JsonProperty(PropertyName = "director_alias")]
    //public LabelUser DirectorAlias { get; set; }

    ///// <summary>
    ///// Card ids used for centralized card limits.
    ///// </summary>
    //[JsonProperty(PropertyName = "card_ids")]
    //public List<BunqId> CardIds { get; set; }

    ///// <summary>
    ///// The centralized limits for user's cards.
    ///// </summary>
    //[JsonProperty(PropertyName = "card_limits")]
    //public List<CardLimit> CardLimits { get; set; }

    ///// <summary>
    ///// The customer profile of the company.
    ///// </summary>
    //[JsonProperty(PropertyName = "customer")]
    //public Customer Customer { get; set; }

    ///// <summary>
    ///// The customer limits of the company.
    ///// </summary>
    //[JsonProperty(PropertyName = "customer_limit")]
    //public CustomerLimit CustomerLimit { get; set; }

    ///// <summary>
    ///// The subscription of the company.
    ///// </summary>
    //[JsonProperty(PropertyName = "billing_contract")]
    //public List<BillingContractSubscription> BillingContract { get; set; }


  }

  [BunqObject("UserCompany")]
  public class UserCompany
  {
    /// <summary>
    /// The company name.
    /// </summary>
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The company's public nick name.
    /// </summary>
    [JsonProperty(PropertyName = "public_nick_name")]
    public string PublicNickName { get; set; }

    /// <summary>
    /// The public UUID of the company's avatar.
    /// </summary>
    [JsonProperty(PropertyName = "avatar_uuid")]
    public string AvatarUuid { get; set; }

    ///// <summary>
    ///// The company's main address.
    ///// </summary>
    //[JsonProperty(PropertyName = "address_main")]
    //public Address AddressMain { get; set; }

    ///// <summary>
    ///// The company's postal address.
    ///// </summary>
    //[JsonProperty(PropertyName = "address_postal")]
    //public Address AddressPostal { get; set; }

    /// <summary>
    /// The person's preferred language. Formatted as a ISO 639-1 language code plus a ISO 3166-1 alpha-2 country
    /// code, seperated by an underscore.
    /// </summary>
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// The person's preferred region. Formatted as a ISO 639-1 language code plus a ISO 3166-1 alpha-2 country
    /// code, seperated by an underscore.
    /// </summary>
    [JsonProperty(PropertyName = "region")]
    public string Region { get; set; }

    /// <summary>
    /// The country as an ISO 3166-1 alpha-2 country code..
    /// </summary>
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    ///// <summary>
    ///// The names of the company's ultimate beneficiary owners. Minimum zero, maximum four.
    ///// </summary>
    //[JsonProperty(PropertyName = "ubo")]
    //public List<Ubo> Ubo { get; set; }

    /// <summary>
    /// The company's chamber of commerce number.
    /// </summary>
    [JsonProperty(PropertyName = "chamber_of_commerce_number")]
    public string ChamberOfCommerceNumber { get; set; }

    /// <summary>
    /// The user status. Can be: ACTIVE, SIGNUP, RECOVERY.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The user sub-status. Can be: NONE, FACE_RESET, APPROVAL, APPROVAL_DIRECTOR, APPROVAL_PARENT,
    /// APPROVAL_SUPPORT, COUNTER_IBAN, IDEAL or SUBMIT.
    /// </summary>
    [JsonProperty(PropertyName = "sub_status")]
    public string SubStatus { get; set; }

    /// <summary>
    /// The setting for the session timeout of the company in seconds.
    /// </summary>
    [JsonProperty(PropertyName = "session_timeout")]
    public int? SessionTimeout { get; set; }

    ///// <summary>
    ///// The amount the company can pay in the session without asking for credentials.
    ///// </summary>
    //[JsonProperty(PropertyName = "daily_limit_without_confirmation_login")]
    //public Amount DailyLimitWithoutConfirmationLogin { get; set; }

    ///// <summary>
    ///// The types of notifications that will result in a push notification or URL callback for this UserCompany.
    ///// </summary>
    //[JsonProperty(PropertyName = "notification_filters")]
    //public List<NotificationFilter> NotificationFilters { get; set; }

    /// <summary>
    /// The id of the modified company.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

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
    /// The company's display name.
    /// </summary>
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// The aliases of the account.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public List<Pointer> Alias { get; set; }

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

    ///// <summary>
    ///// The company's avatar.
    ///// </summary>
    //[JsonProperty(PropertyName = "avatar")]
    //public Avatar Avatar { get; set; }

    /// <summary>
    /// The version of the terms of service accepted by the user.
    /// </summary>
    [JsonProperty(PropertyName = "version_terms_of_service")]
    public string VersionTermsOfService { get; set; }

    ///// <summary>
    ///// The existing bunq user alias for the company's director.
    ///// </summary>
    //[JsonProperty(PropertyName = "director_alias")]
    //public LabelUser DirectorAlias { get; set; }

    ///// <summary>
    ///// Card ids used for centralized card limits.
    ///// </summary>
    //[JsonProperty(PropertyName = "card_ids")]
    //public List<BunqId> CardIds { get; set; }

    ///// <summary>
    ///// The centralized limits for user's cards.
    ///// </summary>
    //[JsonProperty(PropertyName = "card_limits")]
    //public List<CardLimit> CardLimits { get; set; }

    ///// <summary>
    ///// The customer profile of the company.
    ///// </summary>
    //[JsonProperty(PropertyName = "customer")]
    //public Customer Customer { get; set; }

    ///// <summary>
    ///// The customer limits of the company.
    ///// </summary>
    //[JsonProperty(PropertyName = "customer_limit")]
    //public CustomerLimit CustomerLimit { get; set; }

    ///// <summary>
    ///// The subscription of the company.
    ///// </summary>
    //[JsonProperty(PropertyName = "billing_contract")]
    //public List<BillingContractSubscription> BillingContract { get; set; }


  }

  public class DeviceServerInternal
  {
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    [JsonProperty(PropertyName = "secret")]
    public string Secret { get; set; }

    private List<string> _permittedIps;
    [JsonProperty(PropertyName = "permitted_ips")]
    public List<string> PermittedIps
    {
      get { return _permittedIps ?? (_permittedIps = new List<string>()); }
      set { _permittedIps = value; }
    }
  }

  public class SessionServerInitialize
  {
    [JsonProperty(PropertyName = "secret")]
    public string Secret { get; set; }
  }





}
