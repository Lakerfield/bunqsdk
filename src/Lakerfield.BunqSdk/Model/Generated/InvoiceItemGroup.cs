using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("InvoiceItemGroup")]
  public class InvoiceItemGroup
  {
    /// <summary>
    /// The type of the invoice item group.
    /// </summary>
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The description of the type of the invoice item group.
    /// </summary>
    [JsonProperty(PropertyName = "type_description")]
    public string TypeDescription { get; set; }

    /// <summary>
    /// The translated description of the type of the invoice item group.
    /// </summary>
    [JsonProperty(PropertyName = "type_description_translated")]
    public string TypeDescriptionTranslated { get; set; }

    /// <summary>
    /// The identifier of the invoice item group.
    /// </summary>
    [JsonProperty(PropertyName = "instance_description")]
    public string InstanceDescription { get; set; }

    /// <summary>
    /// The unit item price excluding VAT.
    /// </summary>
    [JsonProperty(PropertyName = "product_vat_exclusive")]
    public Amount ProductVatExclusive { get; set; }

    /// <summary>
    /// The unit item price including VAT.
    /// </summary>
    [JsonProperty(PropertyName = "product_vat_inclusive")]
    public Amount ProductVatInclusive { get; set; }

    /// <summary>
    /// The invoice items in the group.
    /// </summary>
    [JsonProperty(PropertyName = "item")]
    public InvoiceItem Item { get; set; }

  }
}
