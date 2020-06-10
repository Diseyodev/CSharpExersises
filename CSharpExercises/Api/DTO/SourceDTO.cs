using Newtonsoft.Json;

namespace Api.DTO
{
    public class SourceDTO
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
