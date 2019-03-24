using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("PermittedIpListing")]
  public class PermittedIpListing
  {
    /// <summary>
    /// The IP address.
    /// </summary>
    [JsonProperty(PropertyName = "ip")]
    public string Ip { get; set; }

    /// <summary>
    /// The status of the IP. May be "ACTIVE" or "INACTIVE". It is only possible to make requests from "ACTIVE" IP addresses. Only "ACTIVE" IPs will be billed.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

  }
}
