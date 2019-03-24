using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("DeviceListing")]
  public class DeviceListing
  {
    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "DeviceServer")]
    public DeviceServer Deviceserver { get; set; }

  }
}
