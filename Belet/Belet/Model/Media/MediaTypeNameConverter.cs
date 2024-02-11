using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.Media
{
    //internal class MediaTypeNameConverter : JsonConverter
    //{
    //    public override bool CanConvert(Type t) => t == typeof(MediaTypeName) || t == typeof(MediaTypeName?);

    //    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //    {
    //        if (reader.TokenType == JsonToken.Null) return null;
    //        var value = serializer.Deserialize<string>(reader);
    //        switch (value)
    //        {
    //            case "anime":
    //                return MediaTypeName.Anime;
    //            case "film":
    //                return MediaTypeName.Film;
    //            case "serial":
    //                return MediaTypeName.Serial;
    //            case "tvshow":
    //                return MediaTypeName.Tvshow;
    //        }
    //        throw new Exception("Cannot unmarshal type MediaTypeName");
    //    }

    //    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //    {
    //        if (untypedValue == null)
    //        {
    //            serializer.Serialize(writer, null);
    //            return;
    //        }
    //        var value = (MediaTypeName)untypedValue;
    //        switch (value)
    //        {
    //            case MediaTypeName.Anime:
    //                serializer.Serialize(writer, "anime");
    //                return;
    //            case MediaTypeName.Film:
    //                serializer.Serialize(writer, "film");
    //                return;
    //            case MediaTypeName.Serial:
    //                serializer.Serialize(writer, "serial");
    //                return;
    //            case MediaTypeName.Tvshow:
    //                serializer.Serialize(writer, "tvshow");
    //                return;
    //        }
    //        throw new Exception("Cannot marshal type MediaTypeName");
    //    }

    //    public static readonly MediaTypeNameConverter Singleton = new MediaTypeNameConverter();
    //}

    internal class MediaTypeNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MediaTypeName) || t == typeof(MediaTypeName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "anime":
                    return MediaTypeName.Anime;
                case "film":
                    return MediaTypeName.Film;
                case "serial":
                    return MediaTypeName.Serial;
                case "tvshow":
                    return MediaTypeName.Tvshow;
            }
            throw new Exception("Cannot unmarshal type MediaTypeName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MediaTypeName)untypedValue;
            switch (value)
            {
                case MediaTypeName.Anime:
                    serializer.Serialize(writer, "anime");
                    return;
                case MediaTypeName.Film:
                    serializer.Serialize(writer, "film");
                    return;
                case MediaTypeName.Serial:
                    serializer.Serialize(writer, "serial");
                    return;
                case MediaTypeName.Tvshow:
                    serializer.Serialize(writer, "tvshow");
                    return;
            }
            throw new Exception("Cannot marshal type MediaTypeName");
        }

        public static readonly MediaTypeNameConverter Singleton = new MediaTypeNameConverter();
    }
}
