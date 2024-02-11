using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.MediaGener
{
    class MediaGener
    {
        [JsonProperty("data")]
        public DatumGener[] Data { get; set; }

        [JsonProperty("meta")]
        public MetaGener Meta { get; set; }
    }
}
