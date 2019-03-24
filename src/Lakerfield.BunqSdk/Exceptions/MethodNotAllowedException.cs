namespace Lakerfield.BunqSdk.Exceptions
{
  public class MethodNotAllowedException : ApiException
  {
    public MethodNotAllowedException(int responseCode, string message, string responseId)
        : base(responseCode, message, responseId)
    {
    }
  }
}
