using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("MonetaryAccountProfile")]
  public class MonetaryAccountProfile
  {
    /// <summary>
    /// The profile settings for triggering the fill of a monetary account.
    /// </summary>
    [JsonProperty(PropertyName = "profile_fill")]
    public MonetaryAccountProfileFill ProfileFill { get; set; }

    /// <summary>
    /// The profile settings for moving excesses to a savings account
    /// </summary>
    [JsonProperty(PropertyName = "profile_drain")]
    public MonetaryAccountProfileDrain ProfileDrain { get; set; }

  }
}
