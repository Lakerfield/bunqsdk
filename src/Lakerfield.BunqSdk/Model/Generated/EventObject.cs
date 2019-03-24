using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("EventObject")]
  public class EventObject
  {
    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "BunqMeTab")]
    public BunqMeTab Bunqmetab { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "BunqMeTabResultResponse")]
    public BunqMeTabResultResponse Bunqmetabresultresponse { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "BunqMeFundraiserResult")]
    public BunqMeFundraiserResult Bunqmefundraiserresult { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "Card")]
    public Card Card { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "CardDebit")]
    public CardDebit Carddebit { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "DraftPayment")]
    public DraftPayment Draftpayment { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "FeatureAnnouncement")]
    public FeatureAnnouncement Featureannouncement { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "IdealMerchantTransaction")]
    public IdealMerchantTransaction Idealmerchanttransaction { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "Invoice")]
    public Invoice Invoice { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "ScheduledPayment")]
    public SchedulePayment Scheduledpayment { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "ScheduledPaymentBatch")]
    public SchedulePaymentBatch Scheduledpaymentbatch { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "ScheduledInstance")]
    public ScheduleInstance Scheduledinstance { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "MasterCardAction")]
    public MasterCardAction Mastercardaction { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "BankSwitchServiceNetherlandsIncomingPayment")]
    public BankSwitchServiceNetherlandsIncomingPayment Bankswitchservicenetherlandsincomingpayment { get; set; }

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
    [JsonProperty(PropertyName = "RequestInquiryBatch")]
    public RequestInquiryBatch Requestinquirybatch { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "RequestInquiry")]
    public RequestInquiry Requestinquiry { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "RequestResponse")]
    public RequestResponse Requestresponse { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "RewardRecipient")]
    public RewardRecipient Rewardrecipient { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "RewardSender")]
    public RewardSender Rewardsender { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "ShareInviteBankInquiryBatch")]
    public ShareInviteBankInquiryBatch Shareinvitebankinquirybatch { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "ShareInviteBankInquiry")]
    public ShareInviteBankInquiry Shareinvitebankinquiry { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "ShareInviteBankResponse")]
    public ShareInviteBankResponse Shareinvitebankresponse { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "SofortMerchantTransaction")]
    public SofortMerchantTransaction Sofortmerchanttransaction { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "TabResultInquiry")]
    public TabResultInquiry Tabresultinquiry { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "TabResultResponse")]
    public TabResultResponse Tabresultresponse { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "TransferwiseTransfer")]
    public TransferwiseTransfer Transferwisetransfer { get; set; }

  }
}
