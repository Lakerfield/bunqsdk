using Newtonsoft.Json;

namespace Lakerfield.BunqSdk.Model
{
  [BunqObject("BunqMeFundraiserProfile")]
  public class BunqMeFundraiserProfile
  {
    /// <summary>
    /// The pointer (url) which will be used to access the bunq.me fundraiser profile.
    /// </summary>
    [JsonProperty(PropertyName = "pointer")]
    public Pointer Pointer { get; set; }

    /// <summary>
    /// The color chosen for the bunq.me fundraiser profile in hexadecimal format.
    /// </summary>
    [JsonProperty(PropertyName = "color")]
    public string Color { get; set; }

    /// <summary>
    /// The LabelMonetaryAccount with the public information of the User and the MonetaryAccount that created the bunq.me fundraiser profile.
    /// </summary>
    [JsonProperty(PropertyName = "alias")]
    public LabelMonetaryAccount Alias { get; set; }

    /// <summary>
    /// The description of the bunq.me fundraiser profile.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The attachments attached to the fundraiser profile.
    /// </summary>
    [JsonProperty(PropertyName = "attachment")]
    public AttachmentPublic[] Attachment { get; set; }

    /// <summary>
    /// The status of the bunq.me fundraiser profile, can be ACTIVE or DEACTIVATED.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The URL which the user is sent to when a payment is completed.
    /// </summary>
    [JsonProperty(PropertyName = "redirect_url")]
    public string RedirectUrl { get; set; }

  }
}
