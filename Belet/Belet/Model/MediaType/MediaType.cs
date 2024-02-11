using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.MediaType
{
    class MediaType
    {
        [JsonProperty("data")]
        public DatumType[] Data { get; set; }

        [JsonProperty("meta")]
        public MetaType Meta { get; set; }
    }
}
