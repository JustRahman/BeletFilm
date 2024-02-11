using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.Reactions
{
    class UserLogsReactions
    {
        [JsonProperty("data")]
        public UserLogsDatumReactions[] Data { get; set; }
    }
}
