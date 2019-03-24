using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("RequestReferenceSplitTheBillAnchorObject")]
  public class RequestReferenceSplitTheBillAnchorObject
  {
    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "BillingInvoice")]
    public Invoice Billinginvoice { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "DraftPayment")]
    public DraftPayment Draftpayment { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "MasterCardAction")]
    public MasterCardAction Mastercardaction { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "Payment")]
    public Payment Payment { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "PaymentBatch")]
    public PaymentBatch Paymentbatch { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "RequestResponse")]
    public RequestResponse Requestresponse { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "ScheduleInstance")]
    public ScheduleInstance Scheduleinstance { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "TabResultResponse")]
    public TabResultResponse Tabresultresponse { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "WhitelistResult")]
    public WhitelistResult Whitelistresult { get; set; }

  }
}
