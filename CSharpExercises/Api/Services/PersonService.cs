using Api.DTO;
using Api.Models;
using Api.Repositories;
using Api.Services.ExternalServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Services
{
    public class PersonService
    {
        private readonly PersonRepository _repository;
        private readonly NewApiService _newApiService;

        public PersonService(PersonRepository repository, NewApiService newApiService)
        {
            _repository = repository;
            _newApiService = newApiService;
        }

        public async Task<IEnumerable<Person>> GetPersonListAsync()
        {
            return await _repository.GetPersonListAsync();
        }

        public async Task<int> AddPersonAsync(Person person)
        {
            return await _repository.AddPersonAsync(person);
        }

        public async Task<Person> GetPersonAsync(int id)
        {
            return await _repository.GetPersonAsync(id);
        }

        public async Task<IEnumerable<ArticleDTO>> GetArticlesAsync()
        {
            return await _newApiService.GetArticlesAsync();
        }

    }
}