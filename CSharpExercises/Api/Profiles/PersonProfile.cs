using Api.DTO;
using Api.Models;
using AutoMapper;

namespace Api.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<PersonDTO, Person>();
            CreateMap<Person, PersonDTO>();
        }
    }
}