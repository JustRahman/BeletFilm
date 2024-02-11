using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.Media
{
    //    internal class CountryNameConverter : JsonConverter
    //    {
    //        public override bool CanConvert(Type t) => t == typeof(CountryName) || t == typeof(CountryName?);

    //        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //        {
    //            if (reader.TokenType == JsonToken.Null) return null;
    //            var value = serializer.Deserialize<string>(reader);
    //            switch (value)
    //            {
    //                case "Japan":
    //                    return CountryName.Japan;
    //                case "Russia":
    //                    return CountryName.Russia;
    //                case "Turkey":
    //                    return CountryName.Turkey;
    //                case "USA":
    //                    return CountryName.Usa;
    //            }
    //            throw new Exception("Cannot unmarshal type CountryName");
    //        }

    //        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //        {
    //            if (untypedValue == null)
    //            {
    //                serializer.Serialize(writer, null);
    //                return;
    //            }
    //            var value = (CountryName)untypedValue;
    //            switch (value)
    //            {
    //                case CountryName.Japan:
    //                    serializer.Serialize(writer, "Japan");
    //                    return;
    //                case CountryName.Russia:
    //                    serializer.Serialize(writer, "Russia");
    //                    return;
    //                case CountryName.Turkey:
    //                    serializer.Serialize(writer, "Turkey");
    //                    return;
    //                case CountryName.Usa:
    //                    serializer.Serialize(writer, "USA");
    //                    return;
    //            }
    //            throw new Exception("Cannot marshal type CountryName");
    //        }

    //        public static readonly CountryNameConverter Singleton = new CountryNameConverter();
    //    }

    //    internal class DirectorNameConverter : JsonConverter
    //    {
    //        public override bool CanConvert(Type t) => t == typeof(DirectorName) || t == typeof(DirectorName?);

    //        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //        {
    //            if (reader.TokenType == JsonToken.Null) return null;
    //            var value = serializer.Deserialize<string>(reader);
    //            switch (value)
    //            {
    //                case "Ali Balcı":
    //                    return DirectorName.AliBalcı;
    //                case "Altan Dönmez":
    //                    return DirectorName.AltanDönmez;
    //                case "Behçet Hıdıroğlu":
    //                    return DirectorName.BehçetHıdıroğlu;
    //                case "Михаил Колпахчиев":
    //                    return DirectorName.МихаилКолпахчиев;
    //                case "Сэм Миллер":
    //                    return DirectorName.СэмМиллер;
    //            }
    //            throw new Exception("Cannot unmarshal type DirectorName");
    //        }

    //        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //        {
    //            if (untypedValue == null)
    //            {
    //                serializer.Serialize(writer, null);
    //                return;
    //            }
    //            var value = (DirectorName)untypedValue;
    //            switch (value)
    //            {
    //                case DirectorName.AliBalcı:
    //                    serializer.Serialize(writer, "Ali Balcı");
    //                    return;
    //                case DirectorName.AltanDönmez:
    //                    serializer.Serialize(writer, "Altan Dönmez");
    //                    return;
    //                case DirectorName.BehçetHıdıroğlu:
    //                    serializer.Serialize(writer, "Behçet Hıdıroğlu");
    //                    return;
    //                case DirectorName.МихаилКолпахчиев:
    //                    serializer.Serialize(writer, "Михаил Колпахчиев");
    //                    return;
    //                case DirectorName.СэмМиллер:
    //                    serializer.Serialize(writer, "Сэм Миллер");
    //                    return;
    //            }
    //            throw new Exception("Cannot marshal type DirectorName");
    //        }

    //        public static readonly DirectorNameConverter Singleton = new DirectorNameConverter();
    //    }

    //    internal class LanguageNameConverter : JsonConverter
    //    {
    //        public override bool CanConvert(Type t) => t == typeof(LanguageName) || t == typeof(LanguageName?);

    //        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //        {
    //            if (reader.TokenType == JsonToken.Null) return null;
    //            var value = serializer.Deserialize<string>(reader);
    //            switch (value)
    //            {
    //                case "russian":
    //                    return LanguageName.Russian;
    //                case "turkish":
    //                    return LanguageName.Turkish;
    //            }
    //            throw new Exception("Cannot unmarshal type LanguageName");
    //        }

    //        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //        {
    //            if (untypedValue == null)
    //            {
    //                serializer.Serialize(writer, null);
    //                return;
    //            }
    //            var value = (LanguageName)untypedValue;
    //            switch (value)
    //            {
    //                case LanguageName.Russian:
    //                    serializer.Serialize(writer, "russian");
    //                    return;
    //                case LanguageName.Turkish:
    //                    serializer.Serialize(writer, "turkish");
    //                    return;
    //            }
    //            throw new Exception("Cannot marshal type LanguageName");
    //        }

    //        public static readonly LanguageNameConverter Singleton = new LanguageNameConverter();
    //    }

    //    internal class ParseStringConverter : JsonConverter
    //    {
    //        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

    //        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //        {
    //            if (reader.TokenType == JsonToken.Null) return null;
    //            var value = serializer.Deserialize<string>(reader);
    //            long l;
    //            if (Int64.TryParse(value, out l))
    //            {
    //                return l;
    //            }
    //            throw new Exception("Cannot unmarshal type long");
    //        }

    //        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //        {
    //            if (untypedValue == null)
    //            {
    //                serializer.Serialize(writer, null);
    //                return;
    //            }
    //            var value = (long)untypedValue;
    //            serializer.Serialize(writer, value.ToString());
    //            return;
    //        }

    //        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    //    }

    //    internal class MediaTypeNameConverter : JsonConverter
    //    {
    //        public override bool CanConvert(Type t) => t == typeof(MediaTypeName) || t == typeof(MediaTypeName?);

    //        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //        {
    //            if (reader.TokenType == JsonToken.Null) return null;
    //            var value = serializer.Deserialize<string>(reader);
    //            switch (value)
    //            {
    //                case "anime":
    //                    return MediaTypeName.Anime;
    //                case "film":
    //                    return MediaTypeName.Film;
    //                case "serial":
    //                    return MediaTypeName.Serial;
    //                case "tvshow":
    //                    return MediaTypeName.Tvshow;
    //            }
    //            throw new Exception("Cannot unmarshal type MediaTypeName");
    //        }

    //        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //        {
    //            if (untypedValue == null)
    //            {
    //                serializer.Serialize(writer, null);
    //                return;
    //            }
    //            var value = (MediaTypeName)untypedValue;
    //            switch (value)
    //            {
    //                case MediaTypeName.Anime:
    //                    serializer.Serialize(writer, "anime");
    //                    return;
    //                case MediaTypeName.Film:
    //                    serializer.Serialize(writer, "film");
    //                    return;
    //                case MediaTypeName.Serial:
    //                    serializer.Serialize(writer, "serial");
    //                    return;
    //                case MediaTypeName.Tvshow:
    //                    serializer.Serialize(writer, "tvshow");
    //                    return;
    //            }
    //            throw new Exception("Cannot marshal type MediaTypeName");
    //        }
    //    }

    internal class CountryNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CountryName) || t == typeof(CountryName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Japan":
                    return CountryName.Japan;
                case "Russia":
                    return CountryName.Russia;
                case "Turkey":
                    return CountryName.Turkey;
                case "USA":
                    return CountryName.Usa;
            }
            throw new Exception("Cannot unmarshal type CountryName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CountryName)untypedValue;
            switch (value)
            {
                case CountryName.Japan:
                    serializer.Serialize(writer, "Japan");
                    return;
                case CountryName.Russia:
                    serializer.Serialize(writer, "Russia");
                    return;
                case CountryName.Turkey:
                    serializer.Serialize(writer, "Turkey");
                    return;
                case CountryName.Usa:
                    serializer.Serialize(writer, "USA");
                    return;
            }
            throw new Exception("Cannot marshal type CountryName");
        }

        public static readonly CountryNameConverter Singleton = new CountryNameConverter();
    }
}
