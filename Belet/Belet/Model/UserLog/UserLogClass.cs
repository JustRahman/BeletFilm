using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.UserLog
{
    class UserLogClass
    {
        [JsonProperty("data")]
        public DatumLog[] Data { get; set; }

        [JsonProperty("meta")]
        public MetaLog Meta { get; set; }
    }
}
