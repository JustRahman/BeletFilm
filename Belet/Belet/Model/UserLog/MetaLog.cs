using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.UserLog
{
    class MetaLog
    {
        [JsonProperty("pagination")]
        public PaginationLog Pagination { get; set; }
    }
}
