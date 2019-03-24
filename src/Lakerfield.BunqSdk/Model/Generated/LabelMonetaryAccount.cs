using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("LabelMonetaryAccount")]
  public class LabelMonetaryAccount
  {
    /// <summary>
    /// The IBAN of the monetary account.
    /// </summary>
    [JsonProperty(PropertyName = "iban")]
    public string Iban { get; set; }

    /// <summary>
    /// The name to display with this monetary account.
    /// </summary>
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// The avatar of the monetary account.
    /// </summary>
    [JsonProperty(PropertyName = "avatar")]
    public Avatar Avatar { get; set; }

    /// <summary>
    /// The user this monetary account belongs to.
    /// </summary>
    [JsonProperty(PropertyName = "label_user")]
    public LabelUser LabelUser { get; set; }

    /// <summary>
    /// The country of the user. Formatted as a ISO 3166-1 alpha-2 country code.
    /// </summary>
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Bunq.me pointer with type and value.
    /// </summary>
    [JsonProperty(PropertyName = "bunq_me")]
    public Pointer BunqMe { get; set; }

    /// <summary>
    /// Whether or not the monetary account is light.
    /// </summary>
    [JsonProperty(PropertyName = "is_light")]
    public bool IsLight { get; set; }

    /// <summary>
    /// The BIC used for a SWIFT payment.
    /// </summary>
    [JsonProperty(PropertyName = "swift_bic")]
    public string SwiftBic { get; set; }

    /// <summary>
    /// The account number used for a SWIFT payment. May or may not be an IBAN.
    /// </summary>
    [JsonProperty(PropertyName = "swift_account_number")]
    public string SwiftAccountNumber { get; set; }

    /// <summary>
    /// The account number used for a Transferwise payment. May or may not be an IBAN.
    /// </summary>
    [JsonProperty(PropertyName = "transferwise_account_number")]
    public string TransferwiseAccountNumber { get; set; }

    /// <summary>
    /// The bank code used for a Transferwise payment. May or may not be a BIC.
    /// </summary>
    [JsonProperty(PropertyName = "transferwise_bank_code")]
    public string TransferwiseBankCode { get; set; }

  }
}
