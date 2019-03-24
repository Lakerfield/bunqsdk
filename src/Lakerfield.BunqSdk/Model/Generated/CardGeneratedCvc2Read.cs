using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("CardGeneratedCvc2Read")]
  public class CardGeneratedCvc2Read
  {
    /// <summary>
    /// The id of the cvc code.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the cvc code's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the cvc code's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The type of generated cvc2. Can be STATIC or GENERATED.
    /// </summary>
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The cvc2 code.
    /// </summary>
    [JsonProperty(PropertyName = "cvc2")]
    public string Cvc2 { get; set; }

    /// <summary>
    /// The status of the cvc2. Can be AVAILABLE, USED, EXPIRED, BLOCKED.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Expiry time of the cvc2.
    /// </summary>
    [JsonProperty(PropertyName = "expiry_time")]
    public string ExpiryTime { get; set; }

  }
}
