﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.Login
{
    class Login
    {
        [JsonProperty("data")]
        public Datum[] Data { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
