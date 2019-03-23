using System;

namespace Lakerfield.BunqSdk
{
  public class Constants
  {
    public static string GetEnvironmentBaseUri(BunqEnvironment environment)
    {
      switch (environment)
      {
        case BunqEnvironment.Sandbox:
          return "https://sandbox.bunq.com/v1/";

        case BunqEnvironment.Production:
          return "https://api.bunq.com/v1/";

        default:
          throw new ArgumentOutOfRangeException(nameof(environment), environment, null);
      }
    }
  }

  public enum BunqEnvironment
  {
    Sandbox,
    Production,
  }
}
