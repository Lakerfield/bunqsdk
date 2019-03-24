using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("WhitelistSddRead")]
  public class WhitelistSddRead
  {
    /// <summary>
    /// The ID of the whitelist entry.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The account to which payments will come in before possibly being 'redirected' by the whitelist.
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_incoming_id")]
    public int MonetaryAccountIncomingId { get; set; }

    /// <summary>
    /// The account from which payments will be deducted when a transaction is matched with this whitelist.
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_paying_id")]
    public int MonetaryAccountPayingId { get; set; }

    /// <summary>
    /// The type of the SDD whitelist, can be CORE or B2B.
    /// </summary>
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The status of the whitelist.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The credit scheme ID provided by the counterparty.
    /// </summary>
    [JsonProperty(PropertyName = "credit_scheme_identifier")]
    public string CreditSchemeIdentifier { get; set; }

    /// <summary>
    /// The mandate ID provided by the counterparty.
    /// </summary>
    [JsonProperty(PropertyName = "mandate_identifier")]
    public string MandateIdentifier { get; set; }

    /// <summary>
    /// The account to which payments will be paid.
    /// </summary>
    [JsonProperty(PropertyName = "counterparty_alias")]
    public LabelMonetaryAccount CounterpartyAlias { get; set; }

    /// <summary>
    /// The monthly maximum amount that can be deducted from the target account.
    /// </summary>
    [JsonProperty(PropertyName = "maximum_amount_per_month")]
    public Amount MaximumAmountPerMonth { get; set; }

    /// <summary>
    /// The user who created the whitelist entry.
    /// </summary>
    [JsonProperty(PropertyName = "user_alias_created")]
    public LabelUser UserAliasCreated { get; set; }

  }
}
