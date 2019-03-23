using System;
using System.Collections.Generic;
using System.Text;

namespace Lakerfield.BunqSdk.Http
{
  public class BunqHeaders
  {
    // From Bunq.Sdk.Http.ApiClient



    /// <summary>
    /// Error constatns.
    /// </summary>
    private static string ERROR_COULD_NOT_DETERMINE_RESPONSE_ID_HEADER =
        "The response header \"X-Bunq-Client-Response-Id\" or \"x-bunq-client-response-id\" could not be found.";

    /// <summary>
    /// Endpoints not requiring active session for the request to succeed.
    /// </summary>
    private const string DEVICE_SERVER_URL = "device-server";
    private const string INSTALLATION_URL = "installation";
    private const string SESSION_SERVER_URL = "session-server";
    private static readonly string[] URIS_NOT_REQUIRING_ACTIVE_SESSION = new string[]
    {
            DEVICE_SERVER_URL,
            INSTALLATION_URL,
            SESSION_SERVER_URL
    };

    /// <summary>
    /// Header constants.
    /// </summary>
    public const string HEADER_ATTACHMENT_DESCRIPTION = "X-Bunq-Attachment-Description";
    public const string HEADER_CONTENT_TYPE = "Content-Type";
    public const string HEADER_CACHE_CONTROL = "Cache-Control";
    public const string HEADER_USER_AGENT = "User-Agent";
    private const string HEADER_LANGUAGE = "X-Bunq-Language";
    private const string HEADER_REGION = "X-Bunq-Region";
    private const string HEADER_REQUEST_ID = "X-Bunq-Client-Request-Id";
    private const string HEADER_GEOLOCATION = "X-Bunq-Geolocation";
    private const string HEADER_SIGNATURE = "X-Bunq-Client-Signature";
    private const string HEADER_AUTHENTICATION = "X-Bunq-Client-Authentication";
    private static string HEADER_RESPONSE_ID_LOWER_CASE = "x-bunq-client-response-id";
    private static string HEADER_RESPONSE_ID_UPPER_CASE = "X-Bunq-Client-Response-Id";

    /// <summary>
    /// Field constants.
    /// </summary>
    private const string FIELD_ERROR = "Error";
    private const string FIELD_ERROR_DESCRIPTION = "error_description";

    /// <summary>
    /// Values for the default headers
    /// </summary>
    private const string CACHE_CONTROL_NONE = "no-cache";
    private const string USER_AGENT_BUNQ = "bunq-sdk-csharp/1.1.0.0";
    private const string LANGUAGE_EN_US = "en_US";
    private const string REGION_NL_NL = "nl_NL";
    private const string GEOLOCATION_ZERO = "0 0 0 0 NL";

    /// <summary>
    /// Delimiter between multiple header values.
    /// </summary>
    private const string DELIMITER_HEADER_VALUE = ",";

    /// <summary>
    /// Delimiter between path and params in URI.
    /// </summary>
    public const char DELIMITER_URI_QUERY = '?';

    /// <summary>
    /// Delimiter between key and value of a URI param.
    /// </summary>
    public const char DELIMITER_URI_PARAM_KEY_VALUE = '=';

    /// <summary>
    /// Delimiter between URI params.
    /// </summary>
    public const char DELIMITER_URI_PARAMS = '&';




  }
}
