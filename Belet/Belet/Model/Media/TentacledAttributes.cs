using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.Media
{
    class TentacledAttributes
    {
        [JsonProperty("gener_name")]
        public string GenerName { get; set; }

        [JsonProperty("gener_description")]
        public object GenerDescription { get; set; }

        [JsonProperty("specot_1")]
        public object Specot1 { get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("publishedAt")]
        public DateTimeOffset PublishedAt { get; set; }
    }
}
