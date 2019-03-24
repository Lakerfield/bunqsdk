using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("UserCredentialPasswordIpRead")]
  public class UserCredentialPasswordIpRead
  {
    /// <summary>
    /// The id of the credential.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the credential object's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the credential object's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The status of the credential.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// When the status is PENDING_FIRST_USE: when the credential expires.
    /// </summary>
    [JsonProperty(PropertyName = "expiry_time")]
    public string ExpiryTime { get; set; }

    /// <summary>
    /// When the status is PENDING_FIRST_USE: the value of the token.
    /// </summary>
    [JsonProperty(PropertyName = "token_value")]
    public string TokenValue { get; set; }

    /// <summary>
    /// When the status is ACTIVE: the details of the device that may use the credential.
    /// </summary>
    [JsonProperty(PropertyName = "permitted_device")]
    public PermittedDevice PermittedDevice { get; set; }

  }
}
