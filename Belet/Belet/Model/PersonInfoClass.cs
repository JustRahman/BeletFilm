using DevExpress.Mvvm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model
{
    class PersonInfoClass: ViewModelBase
    {

        [JsonProperty("PersonId")]
        public int PersonId { get; set; }


        [JsonProperty("PersonPhoneNumber")]
        public string PersonPhoneNumber { get; set; }

     
    }

  
}
