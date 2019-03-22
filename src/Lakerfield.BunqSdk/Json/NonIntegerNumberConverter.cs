using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Lakerfield.BunqSdk.Json
{
  public class NonIntegerNumberConverter : JsonConverter
  {
    private const string FORMAT_DECIMAL = "0.##";

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
      if (value == null)
      {
        writer.WriteNull();
      }
      else
      {
        writer.WriteValue(((decimal)value).ToString(FORMAT_DECIMAL));
      }
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
        JsonSerializer serializer)
    {
      var jToken = JToken.Load(reader);

      if (jToken.Type == JTokenType.String)
      {
        return jToken.ToObject<decimal>();
      }

      return null;
    }

    public override bool CanConvert(Type objectType)
    {
      return objectType == typeof(double?) || objectType == typeof(decimal?) || objectType == typeof(float?);
    }
  }
}
