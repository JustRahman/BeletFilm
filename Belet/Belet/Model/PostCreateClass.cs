using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model
{
    class Data
    {
        public int user_id { get; set; }
        public string user_phone_number { get; set; }
        //public string PublishedAt { get; set; }
        //public string UpdatedAt { get; set; }
        //public string CreatedAt { get; set; }

        //public List<string> UserData { get; set; }
    }
    class Data2
    {
        public int user_id { get; set; }
        public string reaction_type_id { get; set; }
        public int media_id { get; set; }
    }
    class PutCreateClass
    {
        [JsonProperty("data")]
        public Data2 data2 { get; set; }
    }
    class PostCreateClass
    {
        [JsonProperty("data")]
        public Data data { get; set; }
    }

    class PostCreateClass2
    {
        [JsonProperty("data")]
        public Data2 data2 { get; set; }
    }
}
