using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("UserCompanyNameListing")]
  public class UserCompanyNameListing
  {
    /// <summary>
    /// All known (trade) names for a user company.
    /// </summary>
    [JsonProperty(PropertyName = "name_array")]
    public string[] NameArray { get; set; }

  }
}
