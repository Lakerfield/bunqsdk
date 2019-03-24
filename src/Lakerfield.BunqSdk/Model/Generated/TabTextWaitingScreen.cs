using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("TabTextWaitingScreen")]
  public class TabTextWaitingScreen
  {
    /// <summary>
    /// Language of tab text
    /// </summary>
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// Tab text
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

  }
}
