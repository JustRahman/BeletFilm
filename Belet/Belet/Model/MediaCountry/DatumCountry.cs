using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.MediaCountry
{
    class DatumCountry
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("attributes")]
        public AttributesCountry Attributes { get; set; }
    }
}
