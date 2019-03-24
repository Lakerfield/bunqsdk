using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("UserPerson")]
  public class UserPerson
  {
    /// <summary>
    /// The person's first name.
    /// </summary>
    [JsonProperty(PropertyName = "first_name")]
    public string FirstName { get; set; }

    /// <summary>
    /// The person's middle name.
    /// </summary>
    [JsonProperty(PropertyName = "middle_name")]
    public string MiddleName { get; set; }

    /// <summary>
    /// The person's last name.
    /// </summary>
    [JsonProperty(PropertyName = "last_name")]
    public string LastName { get; set; }

    /// <summary>
    /// The public nick name for the person.
    /// </summary>
    [JsonProperty(PropertyName = "public_nick_name")]
    public string PublicNickName { get; set; }

    /// <summary>
    /// The person's main address.
    /// </summary>
    [JsonProperty(PropertyName = "address_main")]
    public Address AddressMain { get; set; }

    /// <summary>
    /// The person's postal address.
    /// </summary>
    [JsonProperty(PropertyName = "address_postal")]
    public Address AddressPostal { get; set; }

    /// <summary>
    /// The public UUID of the user's avatar.
    /// </summary>
    [JsonProperty(PropertyName = "avatar_uuid")]
    public string AvatarUuid { get; set; }

    /// <summary>
    /// The user's tax residence numbers for different countries.
    /// </summary>
    [JsonProperty(PropertyName = "tax_resident")]
    public TaxResident[] TaxResident { get; set; }

    /// <summary>
    /// The type of identification document the person registered with.
    /// </summary>
    [JsonProperty(PropertyName = "document_type")]
    public string DocumentType { get; set; }

    /// <summary>
    /// The identification document number the person registered with.
    /// </summary>
    [JsonProperty(PropertyName = "document_number")]
    public string DocumentNumber { get; set; }

    /// <summary>
    /// The country which issued the identification document the person registered with.
    /// </summary>
    [JsonProperty(PropertyName = "document_country_of_issuance")]
    public string DocumentCountryOfIssuance { get; set; }

    /// <summary>
    /// The reference to the uploaded picture/scan of the front side of the identification document.
    /// </summary>
    [JsonProperty(PropertyName = "document_front_attachment_id")]
    public int DocumentFrontAttachmentId { get; set; }

    /// <summary>
    /// The reference to the uploaded picture/scan of the back side of the identification document.
    /// </summary>
    [JsonProperty(PropertyName = "document_back_attachment_id")]
    public int DocumentBackAttachmentId { get; set; }

    /// <summary>
    /// The person's date of birth. Accepts ISO8601 date formats.
    /// </summary>
    [JsonProperty(PropertyName = "date_of_birth")]
    public string DateOfBirth { get; set; }

    /// <summary>
    /// The person's place of birth.
    /// </summary>
    [JsonProperty(PropertyName = "place_of_birth")]
    public string PlaceOfBirth { get; set; }

    /// <summary>
    /// The person's country of birth. Formatted as a SO 3166-1 alpha-2 country code.
    /// </summary>
    [JsonProperty(PropertyName = "country_of_birth")]
    public string CountryOfBirth { get; set; }

    /// <summary>
    /// The person's nationality. Formatted as a SO 3166-1 alpha-2 country code.
    /// </summary>
    [JsonProperty(PropertyName = "nationality")]
    public string Nationality { get; set; }

    /// <summary>
    /// The person's preferred language. Formatted as a ISO 639-1 language code plus a ISO 3166-1 alpha-2 country code, seperated by an underscore.
    /// </summary>
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// The person's preferred region. Formatted as a ISO 639-1 language code plus a ISO 3166-1 alpha-2 country code, seperated by an underscore.
    /// </summary>
    [JsonProperty(PropertyName = "region")]
    public string Region { get; set; }

    /// <summary>
    /// The person's gender. Can be MALE, FEMALE or UNKNOWN.
    /// </summary>
    [JsonProperty(PropertyName = "gender")]
    public string Gender { get; set; }

    /// <summary>
    /// The user status. The user status. Can be: ACTIVE, BLOCKED, SIGNUP, RECOVERY, DENIED or ABORTED.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The user sub-status. Can be: NONE, FACE_RESET, APPROVAL, APPROVAL_DIRECTOR, APPROVAL_PARENT, APPROVAL_SUPPORT, COUNTER_IBAN, IDEAL or SUBMIT.
    /// </summary>
    [JsonProperty(PropertyName = "sub_status")]
    public string SubStatus { get; set; }

    /// <summary>
    /// The legal guardian of the user. Required for minors.
    /// </summary>
    [JsonProperty(PropertyName = "legal_guardian_alias")]
    public Pointer LegalGuardianAlias { get; set; }

    /// <summary>
    /// The setting for the session timeout of the user in seconds.
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
    /// The amount the user can pay in the session without asking for credentials.
    /// </summary>
    [JsonProperty(PropertyName = "daily_limit_without_confirmation_login")]
    public Amount DailyLimitWithoutConfirmationLogin { get; set; }

    /// <summary>
    /// The types of notifications that will result in a push notification or URL callback for this UserPerson.
    /// </summary>
    [JsonProperty(PropertyName = "notification_filters")]
    public NotificationFilter[] NotificationFilters { get; set; }

    /// <summary>
    /// The display name for the person.
    /// </summary>
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// The id of the modified person object.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the person object's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the person object's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The person's public UUID.
    /// </summary>
    [JsonProperty(PropertyName = "public_uuid")]
    public string PublicUuid { get; set; }

    /// <summary>
    /// The person's legal name.
    /// </summary>
    [JsonProperty(PropertyName = "legal_name")]
    public string LegalName { get; set; }

    /// <summary>
    /// The aliases of the user.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public Pointer[] Alias { get; set; }

    /// <summary>
    /// The user's avatar.
    /// </summary>
    [JsonProperty(PropertyName = "avatar")]
    public Avatar Avatar { get; set; }

    /// <summary>
    /// The version of the terms of service accepted by the user.
    /// </summary>
    [JsonProperty(PropertyName = "version_terms_of_service")]
    public string VersionTermsOfService { get; set; }

  }
}
