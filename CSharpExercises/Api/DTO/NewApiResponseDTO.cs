using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.DTO
{
    public class NewApiResponseDTO
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("articles")]
        public IEnumerable<ArticleDTO> Articles { get; set; }
    }
}