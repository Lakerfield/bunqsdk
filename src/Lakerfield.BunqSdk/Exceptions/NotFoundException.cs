namespace Lakerfield.BunqSdk.Exceptions
{
  public class NotFoundException : ApiException
  {
    public NotFoundException(int responseCode, string message, string responseId)
        : base(responseCode, message, responseId)
    {
    }
  }
}
