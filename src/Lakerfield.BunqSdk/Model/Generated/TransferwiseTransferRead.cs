using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TransferwiseTransferRead")]
  public class TransferwiseTransferRead
  {
    /// <summary>
    /// The LabelMonetaryAccount containing the public information of 'this' (party) side of the Payment.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public LabelMonetaryAccount Alias { get; set; }

    /// <summary>
    /// The LabelMonetaryAccount containing the public information of the other (counterparty) side of the Payment.
    /// </summary>
    [JsonProperty(PropertyName = "counterparty_alias")]
    public LabelMonetaryAccount CounterpartyAlias { get; set; }

    /// <summary>
    /// The status.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The subStatus.
    /// </summary>
    [JsonProperty(PropertyName = "sub_status")]
    public string SubStatus { get; set; }

    /// <summary>
    /// The status as Transferwise reports it.
    /// </summary>
    [JsonProperty(PropertyName = "status_transferwise")]
    public string StatusTransferwise { get; set; }

    /// <summary>
    /// A status to indicatie if Transferwise has an issue with this payment and requires more information.
    /// </summary>
    [JsonProperty(PropertyName = "status_transferwise_issue")]
    public string StatusTransferwiseIssue { get; set; }

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
    /// The rate of the payment.
    /// </summary>
    [JsonProperty(PropertyName = "rate")]
    public string Rate { get; set; }

    /// <summary>
    /// The reference of the payment.
    /// </summary>
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    /// <summary>
    /// The Pay-In reference of the payment.
    /// </summary>
    [JsonProperty(PropertyName = "pay_in_reference")]
    public string PayInReference { get; set; }

    /// <summary>
    /// The estimated delivery time.
    /// </summary>
    [JsonProperty(PropertyName = "time_delivery_estimate")]
    public string TimeDeliveryEstimate { get; set; }

    /// <summary>
    /// The quote details used to created the payment.
    /// </summary>
    [JsonProperty(PropertyName = "quote")]
    public TransferwiseQuote Quote { get; set; }

  }
}
