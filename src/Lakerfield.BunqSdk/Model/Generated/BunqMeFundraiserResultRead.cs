using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("BunqMeFundraiserResultRead")]
  public class BunqMeFundraiserResultRead
  {
    /// <summary>
    /// The id of the bunq.me.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp when the bunq.me was created.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp when the bunq.me was last updated.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The bunq.me fundraiser profile.
    /// </summary>
    [JsonProperty(PropertyName = "bunqme_fundraiser_profile")]
    public BunqMeFundraiserProfile BunqmeFundraiserProfile { get; set; }

    /// <summary>
    /// The list of payments, paid to the bunq.me fundraiser profile.
    /// </summary>
    [JsonProperty(PropertyName = "payments")]
    public Payment[] Payments { get; set; }

  }
}
