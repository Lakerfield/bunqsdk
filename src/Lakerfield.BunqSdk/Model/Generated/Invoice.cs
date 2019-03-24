using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("Invoice")]
  public class Invoice
  {
    /// <summary>
    /// The invoice status.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The description provided by the admin.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The external url provided by the admin.
    /// </summary>
    [JsonProperty(PropertyName = "external_url")]
    public string ExternalUrl { get; set; }

    /// <summary>
    /// The id of the invoice object.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the invoice object's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the invoice object's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The invoice date.
    /// </summary>
    [JsonProperty(PropertyName = "invoice_date")]
    public string InvoiceDate { get; set; }

    /// <summary>
    /// The invoice number.
    /// </summary>
    [JsonProperty(PropertyName = "invoice_number")]
    public string InvoiceNumber { get; set; }

    /// <summary>
    /// The invoice item groups.
    /// </summary>
    [JsonProperty(PropertyName = "group")]
    public InvoiceItemGroup[] Group { get; set; }

    /// <summary>
    /// The total discounted item price including VAT.
    /// </summary>
    [JsonProperty(PropertyName = "total_vat_inclusive")]
    public Amount TotalVatInclusive { get; set; }

    /// <summary>
    /// The total discounted item price excluding VAT.
    /// </summary>
    [JsonProperty(PropertyName = "total_vat_exclusive")]
    public Amount TotalVatExclusive { get; set; }

    /// <summary>
    /// The VAT on the total discounted item price.
    /// </summary>
    [JsonProperty(PropertyName = "total_vat")]
    public Amount TotalVat { get; set; }

    /// <summary>
    /// The label that's displayed to the counterparty with the invoice. Includes user.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public LabelMonetaryAccount Alias { get; set; }

    /// <summary>
    /// The customer's address.
    /// </summary>
    [JsonProperty(PropertyName = "address")]
    public Address Address { get; set; }

    /// <summary>
    /// The label of the counterparty of the invoice. Includes user.
    /// </summary>
    [JsonProperty(PropertyName = "counterparty_alias")]
    public LabelMonetaryAccount CounterpartyAlias { get; set; }

    /// <summary>
    /// The company's address.
    /// </summary>
    [JsonProperty(PropertyName = "counterparty_address")]
    public Address CounterpartyAddress { get; set; }

    /// <summary>
    /// The company's chamber of commerce number.
    /// </summary>
    [JsonProperty(PropertyName = "chamber_of_commerce_number")]
    public string ChamberOfCommerceNumber { get; set; }

    /// <summary>
    /// The company's chamber of commerce number.
    /// </summary>
    [JsonProperty(PropertyName = "vat_number")]
    public string VatNumber { get; set; }

    /// <summary>
    /// The reference to the object used for split the bill. Can be RequestInquiry or RequestInquiryBatch
    /// </summary>
    [JsonProperty(PropertyName = "request_reference_split_the_bill")]
    public RequestInquiryReference[] RequestReferenceSplitTheBill { get; set; }

  }
}
