using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.Media
{
    class Pagination
    {
        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("pageSize")]
        public long PageSize { get; set; }

        [JsonProperty("pageCount")]
        public long PageCount { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }

    public enum CountryName { Japan, Russia, Turkey, Usa };

    public enum DirectorName { AliBalcı, AltanDönmez, BehçetHıdıroğlu, МихаилКолпахчиев, СэмМиллер };

    public enum LanguageName { Russian, Turkish };

    public enum MediaTypeName { Anime, Film, Serial, Tvshow };
}
