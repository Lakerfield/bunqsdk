using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TransferwiseQuote")]
  public class TransferwiseQuote
  {
    /// <summary>
    /// The source currency.
    /// </summary>
    [JsonProperty(PropertyName = "currency_source")]
    public string CurrencySource { get; set; }

    /// <summary>
    /// The target currency.
    /// </summary>
    [JsonProperty(PropertyName = "currency_target")]
    public string CurrencyTarget { get; set; }

    /// <summary>
    /// The source amount.
    /// </summary>
    [JsonProperty(PropertyName = "amount_source")]
    public Amount AmountSource { get; set; }

    /// <summary>
    /// The target amount.
    /// </summary>
    [JsonProperty(PropertyName = "amount_target")]
    public Amount AmountTarget { get; set; }

    /// <summary>
    /// The id of the quote.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the quote's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the quote's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The expiration timestamp of the quote.
    /// </summary>
    [JsonProperty(PropertyName = "time_expiry")]
    public string TimeExpiry { get; set; }

    /// <summary>
    /// The quote id Transferwise needs.
    /// </summary>
    [JsonProperty(PropertyName = "quote_id")]
    public string QuoteId { get; set; }

    /// <summary>
    /// The fee amount.
    /// </summary>
    [JsonProperty(PropertyName = "amount_fee")]
    public Amount AmountFee { get; set; }

    /// <summary>
    /// The rate.
    /// </summary>
    [JsonProperty(PropertyName = "rate")]
    public string Rate { get; set; }

    /// <summary>
    /// The estimated delivery time.
    /// </summary>
    [JsonProperty(PropertyName = "time_delivery_estimate")]
    public string TimeDeliveryEstimate { get; set; }

  }
}
