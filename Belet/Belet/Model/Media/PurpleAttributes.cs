using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.Media
{
    class PurpleAttributes
    {

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("publishedAt")]
        public DateTimeOffset PublishedAt { get; set; }

        [JsonProperty("media_name")]
        public string MediaName { get; set; }

        [JsonProperty("media_description")]
        public string MediaDescription { get; set; }

        [JsonProperty("media_full_name")]
        public object MediaFullName { get; set; }

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

        [JsonProperty("tbl_rb_geners")]
        public TblRbGeners TblRbGeners { get; set; }

        [JsonProperty("tbl_rb_media_actors")]
        public TblRb TblRbMediaActors { get; set; }

        [JsonProperty("tbl_rb_languages")]
        public TblRb TblRbLanguages { get; set; }

        [JsonProperty("tbl_rb_year")]
        public TblRbYear TblRbYear { get; set; }

        [JsonProperty("tbl_rb_media_directors")]
        public TblRb TblRbMediaDirectors { get; set; }

        [JsonProperty("tbl_rb_countries")]
        public TblRb TblRbCountries { get; set; }

        [JsonProperty("tbl_rb_media_type")]
        public TblRbMediaType TblRbMediaType { get; set; }




    }
}
