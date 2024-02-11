using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.NewMedia
{
    class Media
    {
        [JsonProperty("data")]
        public MediaDatum[] Data { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
