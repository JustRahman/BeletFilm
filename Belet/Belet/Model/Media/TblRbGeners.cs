using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.Media
{
    class TblRbGeners
    {
        [JsonProperty("data")]
        public TblRbGenersDatum[] Data { get; set; }
    }
}
