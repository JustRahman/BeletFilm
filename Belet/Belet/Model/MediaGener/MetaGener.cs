using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.MediaGener
{
    class MetaGener
    {
        [JsonProperty("pagination")]
        public PaginationGener Pagination { get; set; }
    }
}
