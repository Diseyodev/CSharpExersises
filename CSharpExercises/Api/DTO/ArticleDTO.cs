using Newtonsoft.Json;

namespace Api.DTO
{
    public class ArticleDTO
    {
        [JsonProperty("Source")]
        public SourceDTO Source { get; set; }

        [JsonProperty("autor")]
        public string Author { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("url_to_image")]
        public string UrlToImage { get; set; }

        [JsonProperty("published_at")]
        public string PublishedAt { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}