using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.MediaCountry
{
    class MediaCountry
    {
        [JsonProperty("data")]
        public DatumCountry[] Data { get; set; }

        [JsonProperty("meta")]
        public MetaCountry Meta { get; set; }
    }
}
