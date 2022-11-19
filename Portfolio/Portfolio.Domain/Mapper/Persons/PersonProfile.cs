using AutoMapper;
using Portfolio.Domain.AppCode.DTOs.PersonDTOs;
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.Entites;
namespace Portfolio.Domain.Mapper.Persons
{
    public class PersonProfile:Profile
    {
        public PersonProfile()
        {
            CreateMap<Person,PersonDto>().ReverseMap();
        }
    }
}
