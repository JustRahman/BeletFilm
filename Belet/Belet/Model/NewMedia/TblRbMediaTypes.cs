using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.NewMedia
{
    class TblRbMediaTypes
    {
        [JsonProperty("data")]
        public TblRbMediaTypesDatum[] Data { get; set; }
    }
}
