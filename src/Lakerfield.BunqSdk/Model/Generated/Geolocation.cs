using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("Geolocation")]
  public class Geolocation
  {
    /// <summary>
    /// The latitude for a geolocation restriction.
    /// </summary>
    [JsonProperty(PropertyName = "latitude")]
    public int Latitude { get; set; }

    /// <summary>
    /// The longitude for a geolocation restriction.
    /// </summary>
    [JsonProperty(PropertyName = "longitude")]
    public int Longitude { get; set; }

    /// <summary>
    /// The altitude for a geolocation restriction.
    /// </summary>
    [JsonProperty(PropertyName = "altitude")]
    public int Altitude { get; set; }

    /// <summary>
    /// The radius for a geolocation restriction.
    /// </summary>
    [JsonProperty(PropertyName = "radius")]
    public int Radius { get; set; }

  }
}
