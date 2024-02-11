using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.MediaType
{
    class MetaType
    {
        [JsonProperty("pagination")]
        public PaginationType Pagination { get; set; }
    }
}
