using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("EventRead")]
  public class EventRead
  {
    /// <summary>
    /// The id of the event.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }

    /// <summary>
    /// The timestamp of the event's creation.
    /// </summary>
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// The timestamp of the event's last update.
    /// </summary>
    [JsonProperty(PropertyName = "updated")]
    public string Updated { get; set; }

    /// <summary>
    /// The performed action. Can be: CREATE or UPDATE.
    /// </summary>
    [JsonProperty(PropertyName = "action")]
    public string Action { get; set; }

    /// <summary>
    /// The id of the user the event applied to (if it was a user event).
    /// </summary>
    [JsonProperty(PropertyName = "user_id")]
    public string UserId { get; set; }

    /// <summary>
    /// The id of the monetary account the event applied to (if it was a monetary account event).
    /// </summary>
    [JsonProperty(PropertyName = "monetary_account_id")]
    public string MonetaryAccountId { get; set; }

    /// <summary>
    /// The details of the external object the event was created for.
    /// </summary>
    [JsonProperty(PropertyName = "object")]
    public EventObject Object { get; set; }

    /// <summary>
    /// The event status. Can be: FINALIZED or AWAITING_REPLY. An example of FINALIZED event is a payment received event, while an AWAITING_REPLY event is a request received event.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

  }
}
