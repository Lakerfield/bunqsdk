using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("UserRead")]
  public class UserRead
  {
    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "UserLight")]
    public UserLight Userlight { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "UserPerson")]
    public UserPerson Userperson { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "UserCompany")]
    public UserCompany Usercompany { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "UserApiKey")]
    public UserApiKey Userapikey { get; set; }

  }
}
