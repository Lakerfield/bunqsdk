using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("Customer")]
  public class Customer
  {
    /// <summary>
    /// The primary billing account account's id.
    /// </summary>
    [JsonProperty(PropertyName = "billing_account_id")]
    public string BillingAccountId { get; set; }

    /// <summary>
    /// The preferred notification type for invoices.
    /// </summary>
    [JsonProperty(PropertyName = "invoice_notification_preference")]
    public string InvoiceNotificationPreference { get; set; }

    /// <summary>
    /// The id of the customer.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the customer object's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the customer object's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

  }
}
