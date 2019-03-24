namespace Lakerfield.BunqSdk.Exceptions
{
  public class ForbiddenException : ApiException
  {
    public ForbiddenException(int responseCode, string message, string responseId)
        : base(responseCode, message, responseId)
    {
    }
  }
}
