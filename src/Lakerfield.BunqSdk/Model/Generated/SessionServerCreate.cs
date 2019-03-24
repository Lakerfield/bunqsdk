using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("SessionServerCreate")]
  public class SessionServerCreate
  {
    /// <summary>
    /// The Id object of the created Session.
    /// </summary>
    [JsonProperty(PropertyName = "Id")]
    public BunqId Id { get; set; }

    /// <summary>
    /// The token object of this Session.
    /// </summary>
    [JsonProperty(PropertyName = "Token")]
    public SessionServerToken Token { get; set; }

    /// <summary>
    /// The UserCompany object that is logged in with this Session.
    /// </summary>
    [JsonProperty(PropertyName = "UserCompany")]
    public UserCompany Usercompany { get; set; }

    /// <summary>
    /// The UserPerson object that is logged in with this Session.
    /// </summary>
    [JsonProperty(PropertyName = "UserPerson")]
    public UserPerson Userperson { get; set; }

    /// <summary>
    /// The UserApiKey object that is logged in with this Session.
    /// </summary>
    [JsonProperty(PropertyName = "UserApiKey")]
    public UserApiKey Userapikey { get; set; }

  }
}
