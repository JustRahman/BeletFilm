using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.Reactions
{
    class Reaction
    {
        [JsonProperty("data")]
        public DatumReactions[] Data { get; set; }

        [JsonProperty("meta")]
        public MetaReaction Meta { get; set; }


    }
}
