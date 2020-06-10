using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.DTO
{
    public class NewApiResponseDTO
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("articles")]
        public IEnumerable<ArticleDTO> Articles { get; set; }
    }
}