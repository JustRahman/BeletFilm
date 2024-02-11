using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.MediaCountry
{
    class MetaCountry
    {
        [JsonProperty("pagination")]
        public PaginationCountry Pagination { get; set; }
    }
}
