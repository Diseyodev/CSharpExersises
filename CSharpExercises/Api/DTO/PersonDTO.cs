using Newtonsoft.Json;

namespace Api.DTO
{
    public class PersonDTO
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("identification")]
        public string Identification { get; set; }

        [JsonProperty("genre")]
        public string Genre { get; set; }
    }
}