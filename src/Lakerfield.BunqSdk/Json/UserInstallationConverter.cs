using System;
using System.Collections.Generic;
using System.Text;
using Bunq.Sdk.Security;
using Lakerfield.BunqSdk.Context;
using Lakerfield.BunqSdk.Store;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Lakerfield.BunqSdk.Json
{
  public class UserInstallationConverter : JsonConverter<UserInstallation>
  {
    private const string FIELD_TOKEN = "Token";
    private const string FIELD_PRIVATE_KEY_CLIENT = "ClientKeyPrivate";
    private const string FIELD_PUBLIC_KEY_CLIENT = "ClientKeyPublic";
    private const string FIELD_PUBLIC_KEY_SERVER = "ServerKeyPublic";

    public override void WriteJson(JsonWriter writer, UserInstallation value, JsonSerializer serializer)
    {
      writer.WriteStartObject();

      writer.WritePropertyName(FIELD_TOKEN);
      serializer.Serialize(writer, value.Token);

      writer.WritePropertyName(FIELD_PUBLIC_KEY_CLIENT);
      var clientPublicKeyString = SecurityUtils.GetPublicKeyFormattedString(value.ClientKeyPair);
      serializer.Serialize(writer, clientPublicKeyString);

      writer.WritePropertyName(FIELD_PRIVATE_KEY_CLIENT);
      var clientPrivateKeyString = SecurityUtils.GetPrivateKeyFormattedString(value.ClientKeyPair);
      serializer.Serialize(writer, clientPrivateKeyString);

      writer.WritePropertyName(FIELD_PUBLIC_KEY_SERVER);
      var serverPublicKeyString = SecurityUtils.GetPublicKeyFormattedString(value.ServerPublicKey);
      serializer.Serialize(writer, serverPublicKeyString);

      writer.WriteEndObject();
    }

    public override UserInstallation ReadJson(JsonReader reader, Type objectType, UserInstallation existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
      var jObject = JObject.Load(reader);

      var installationToken = jObject.GetValue(FIELD_TOKEN).ToString();
      var privateKeyClientString = jObject.GetValue(FIELD_PRIVATE_KEY_CLIENT).ToString();
      var keyPairClient = SecurityUtils.CreateKeyPairFromPrivateKeyFormattedString(privateKeyClientString);
      var publicKeyServerString = jObject.GetValue(FIELD_PUBLIC_KEY_SERVER).ToString();
      var publicKeyServer = SecurityUtils.CreatePublicKeyFromPublicKeyFormattedString(publicKeyServerString);

      return new UserInstallation()
      {
        Token = installationToken,
        ClientKeyPair = keyPairClient,
        ServerPublicKey = publicKeyServer
      };
    }

  }
}
