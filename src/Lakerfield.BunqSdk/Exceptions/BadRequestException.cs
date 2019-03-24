namespace Lakerfield.BunqSdk.Exceptions
{
  public class BadRequestException : ApiException
  {
    public BadRequestException(int responseCode, string message, string responseId)
        : base(responseCode, message, responseId)
    {
    }
  }
}
