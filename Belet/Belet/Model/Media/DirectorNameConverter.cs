using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.Media
{
    internal class DirectorNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DirectorName) || t == typeof(DirectorName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Ali Balcı":
                    return DirectorName.AliBalcı;
                case "Altan Dönmez":
                    return DirectorName.AltanDönmez;
                case "Behçet Hıdıroğlu":
                    return DirectorName.BehçetHıdıroğlu;
                case "Михаил Колпахчиев":
                    return DirectorName.МихаилКолпахчиев;
                case "Сэм Миллер":
                    return DirectorName.СэмМиллер;
            }
            throw new Exception("Cannot unmarshal type DirectorName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DirectorName)untypedValue;
            switch (value)
            {
                case DirectorName.AliBalcı:
                    serializer.Serialize(writer, "Ali Balcı");
                    return;
                case DirectorName.AltanDönmez:
                    serializer.Serialize(writer, "Altan Dönmez");
                    return;
                case DirectorName.BehçetHıdıroğlu:
                    serializer.Serialize(writer, "Behçet Hıdıroğlu");
                    return;
                case DirectorName.МихаилКолпахчиев:
                    serializer.Serialize(writer, "Михаил Колпахчиев");
                    return;
                case DirectorName.СэмМиллер:
                    serializer.Serialize(writer, "Сэм Миллер");
                    return;
            }
            throw new Exception("Cannot marshal type DirectorName");
        }

        public static readonly DirectorNameConverter Singleton = new DirectorNameConverter();
    }
}
