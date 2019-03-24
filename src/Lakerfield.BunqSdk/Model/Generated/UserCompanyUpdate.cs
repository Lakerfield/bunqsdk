using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("UserCompanyUpdate")]
  public class UserCompanyUpdate
  {
    /// <summary>
    /// The id of the modified company.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

  }
}
