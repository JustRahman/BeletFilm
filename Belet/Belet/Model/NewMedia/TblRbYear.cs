﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.NewMedia
{
    class TblRbYear
    {
        [JsonProperty("data")]
        public Dat Data { get; set; }
    }
}
