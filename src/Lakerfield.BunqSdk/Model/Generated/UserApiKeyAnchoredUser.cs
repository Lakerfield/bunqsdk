using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("UserApiKeyAnchoredUser")]
  public class UserApiKeyAnchoredUser
  {
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

  }
}
