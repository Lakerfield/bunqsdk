using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("LabelCard")]
  public class LabelCard
  {
    /// <summary>
    /// The public UUID.
    /// </summary>
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// The type of the card.
    /// </summary>
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The second line on the card.
    /// </summary>
    [JsonProperty(PropertyName = "second_line")]
    public string SecondLine { get; set; }

    /// <summary>
    /// The date this card will expire.
    /// </summary>
    [JsonProperty(PropertyName = "expiry_date")]
    public string ExpiryDate { get; set; }

    /// <summary>
    /// The status of the card.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The owner of this card.
    /// </summary>
    [JsonProperty(PropertyName = "label_user")]
    public LabelUser LabelUser { get; set; }

  }
}
