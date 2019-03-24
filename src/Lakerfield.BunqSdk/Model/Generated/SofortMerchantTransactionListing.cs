using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("SofortMerchantTransactionListing")]
  public class SofortMerchantTransactionListing
  {
    /// <summary>
    /// The id of the monetary account this sofort merchant transaction links to.
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_id")]
    public int MonetaryAccountId { get; set; }

    /// <summary>
    /// The alias of the monetary account to add money to.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public LabelMonetaryAccount Alias { get; set; }

    /// <summary>
    /// The alias of the monetary account the money comes from.
    /// </summary>
    [JsonProperty(PropertyName = "counterparty_alias")]
    public LabelMonetaryAccount CounterpartyAlias { get; set; }

    /// <summary>
    /// In case of a successful transaction, the amount of money that will be transferred.
    /// </summary>
    [JsonProperty(PropertyName = "amount_guaranteed")]
    public Amount AmountGuaranteed { get; set; }

    /// <summary>
    /// The requested amount of money to add.
    /// </summary>
    [JsonProperty(PropertyName = "amount_requested")]
    public Amount AmountRequested { get; set; }

    /// <summary>
    /// The BIC of the issuer.
    /// </summary>
    [JsonProperty(PropertyName = "issuer")]
    public string Issuer { get; set; }

    /// <summary>
    /// The URL to visit to 
    /// </summary>
    [JsonProperty(PropertyName = "issuer_authentication_url")]
    public string IssuerAuthenticationUrl { get; set; }

    /// <summary>
    /// The status of the transaction.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    // TODO: Skipped property error_message

    /// <summary>
    /// The 'transaction ID' of the Sofort transaction.
    /// </summary>
    [JsonProperty(PropertyName = "transaction_identifier")]
    public string TransactionIdentifier { get; set; }

  }
}
