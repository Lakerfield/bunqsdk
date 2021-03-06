﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Lakerfield.BunqSdk.Exceptions;

namespace Lakerfield.BunqSdk.Model
{
  public class BunqResponse
  {
    public Dictionary<string, string> Headers { get; }
    private readonly JArray _array;

    public BunqResponse(JArray array, Dictionary<string, string> headers = null)
    {
      Headers = headers;
      _array = array;
    }

    public T Get<T>()
    {
      if (_array == null)
        return default(T);

      var attribute = typeof(T).GetCustomAttribute<BunqObjectAttribute>();
      if (attribute == null)
        throw new BunqException("Cannot find BunqObjectAttribute");

      foreach (var token in _array)
      {
        if (token.Type != JTokenType.Object)
          continue;

        var response = (JObject)token;
        if (!response.TryGetValue(attribute.Name, out var result))
          continue;

        return result.ToObject<T>();
      }

      return default(T);
    }

  }


  [BunqObject("ApiKey")]
  public class ApiKey
  {
    [JsonProperty(PropertyName = "api_key")]
    public string Value { get; set; }
  }






}
