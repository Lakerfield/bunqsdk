using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("UserLegalNameListing")]
  public class UserLegalNameListing
  {
    /// <summary>
    /// All legal names that can be used by the user
    /// </summary>
    [JsonProperty(PropertyName = "legal_names")]
    public string[] LegalNames { get; set; }

  }
}
