using Api.DTO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Api.Services.ExternalServices
{
    public class NewApiService
    {
        private readonly HttpClient _client;

        public NewApiService()
        {
            _client = new HttpClient();
        }

        public async Task<IEnumerable<ArticleDTO>> GetArticlesAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "http://newsapi.org/v2/everything?q=bitcoin&from=2020-05-09&sortBy=publishedAt&apiKey=2ee3383df4e24e8d89258d546ca6b247");

            var response = await _client.SendAsync(request);

            NewApiResponseDTO newApiResponse = JsonConvert.DeserializeObject<NewApiResponseDTO>(await response.Content.ReadAsStringAsync());

            return newApiResponse.Articles;
        }
    }
}