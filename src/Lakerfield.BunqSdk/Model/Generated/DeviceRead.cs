using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("DeviceRead")]
  public class DeviceRead
  {
    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "DeviceServer")]
    public DeviceServer Deviceserver { get; set; }

  }
}
