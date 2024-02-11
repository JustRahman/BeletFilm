using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belet.Model.Media
{
    class FluffyAttributes
    {
        [JsonProperty("country_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryName { get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("publishedAt")]
        public DateTimeOffset PublishedAt { get; set; }

        [JsonProperty("language_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageName { get; set; }

        [JsonProperty("actor_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ActorName { get; set; }

        [JsonProperty("director_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DirectorName { get; set; }

        [JsonProperty("year", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Year { get; set; }
    }
}
