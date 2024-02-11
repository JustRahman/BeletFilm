using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.Media
{
    class NecessaryMedia
    {
        [JsonProperty("acceptableyear")]
        public int? MediaId { get; set; }

        [JsonProperty("media_name")]
        public string MediaName { get; set; }

        [JsonProperty("media_description")]
        public string MediaDescription { get; set; }

        

        [JsonProperty("media_picture1")]
        public string MediaPicture1 { get; set; }

        [JsonProperty("media_picture2")]
        public string MediaPicture2 { get; set; }

        [JsonProperty("firstrating")]
        public double? Firstrating { get; set; }

        [JsonProperty("secondrating")]
        public double? Secondrating { get; set; }

        [JsonProperty("acceptableyear")]
        public long? Acceptableyear { get; set; }

        [JsonProperty("duration")]
        public double? Duration { get; set; }

        [JsonProperty("gener_name")]
        public ObservableCollection<string> GenerName { get; set; }

        [JsonProperty("tbl_rb_media_actors")]
        public ObservableCollection<string> TblRbMediaActors { get; set; }

        [JsonProperty("tbl_rb_languages")]
        public ObservableCollection<string> TblRbLanguages { get; set; }

        [JsonProperty("tbl_rb_year")]
        public string TblRbYear { get; set; }

        [JsonProperty("tbl_rb_media_director")]
        public string TblRbMediaDirector { get; set; }

        [JsonProperty("tbl_rb_countries")]
        public ObservableCollection<string> TblRbCountries { get; set; }

        [JsonProperty("tbl_rb_media_type")]
        public string TblRbMediaType { get; set; }
    }
}
