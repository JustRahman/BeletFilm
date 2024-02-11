using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.Media
{
    //internal class LanguageNameConverter : JsonConverter
    //{
    //    public override bool CanConvert(Type t) => t == typeof(LanguageName) || t == typeof(LanguageName?);

    //    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //    {
    //        if (reader.TokenType == JsonToken.Null) return null;
    //        var value = serializer.Deserialize<string>(reader);
    //        switch (value)
    //        {
    //            case "russian":
    //                return LanguageName.Russian;
    //            case "turkish":
    //                return LanguageName.Turkish;
    //        }
    //        throw new Exception("Cannot unmarshal type LanguageName");
    //    }

    //    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //    {
    //        if (untypedValue == null)
    //        {
    //            serializer.Serialize(writer, null);
    //            return;
    //        }
    //        var value = (LanguageName)untypedValue;
    //        switch (value)
    //        {
    //            case LanguageName.Russian:
    //                serializer.Serialize(writer, "russian");
    //                return;
    //            case LanguageName.Turkish:
    //                serializer.Serialize(writer, "turkish");
    //                return;
    //        }
    //        throw new Exception("Cannot marshal type LanguageName");
    //    }

    //    public static readonly LanguageNameConverter Singleton = new LanguageNameConverter();
    //}

    internal class LanguageNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LanguageName) || t == typeof(LanguageName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "russian":
                    return LanguageName.Russian;
                case "turkish":
                    return LanguageName.Turkish;
            }
            throw new Exception("Cannot unmarshal type LanguageName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LanguageName)untypedValue;
            switch (value)
            {
                case LanguageName.Russian:
                    serializer.Serialize(writer, "russian");
                    return;
                case LanguageName.Turkish:
                    serializer.Serialize(writer, "turkish");
                    return;
            }
            throw new Exception("Cannot marshal type LanguageName");
        }

        public static readonly LanguageNameConverter Singleton = new LanguageNameConverter();
    }
}
