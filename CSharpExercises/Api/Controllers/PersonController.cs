using Api.DTO;
using Api.Models;
using Api.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly PersonService _service;

        public PersonController(PersonService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        // GET: api/Person
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonDTO>>> GetAll()
        {
            var personList = await _service.GetPersonListAsync();

            var personListDTO = _mapper.Map<IEnumerable<PersonDTO>>(personList);

            return personListDTO.ToList();
        }

        // GET: api/Person/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<PersonDTO>> Get(int id)
        {
            var person = await _service.GetPersonAsync(id);

            if (person == null)
            {
                return NotFound();
            }

            var personDTO = _mapper.Map<PersonDTO>(person);

            return personDTO;
        }

        // POST: api/Person
        [HttpPost]
        public async Task<ActionResult<PersonDTO>> Post([FromBody] PersonDTO dto)
        {
            var person = _mapper.Map<Person>(dto);

            var id = await _service.AddPersonAsync(person);

            return CreatedAtAction("Get", new { id }, person);
        }

        // PUT: api/Person/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet]
        [Route("articles")]
        public async Task<IEnumerable<ArticleDTO>> GetArticles()
        {
            return await _service.GetArticlesAsync();
        }
    }
}