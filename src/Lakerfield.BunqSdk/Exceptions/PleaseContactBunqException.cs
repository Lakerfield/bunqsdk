namespace Lakerfield.BunqSdk.Exceptions
{
  public class PleaseContactBunqException : ApiException
  {
    public PleaseContactBunqException(int responseCode, string message, string responseId)
        : base(responseCode, message, responseId)
    {
    }
  }
}
