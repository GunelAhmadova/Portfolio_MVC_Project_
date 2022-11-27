using AutoMapper;
using Portfolio.Domain.AppCode.DTOs.PersonDTOs;
using Portfolio.Domain.AppCode.DTOs.ServiceDTOs;
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.Entites;
using System.Collections;
using System.Collections.Generic;

namespace Portfolio.Domain.Mapper.Persons
{
    public class PersonProfile:Profile
    {
        public PersonProfile()
        {
            CreateMap<Person,PersonDto>().ReverseMap();
            CreateMap <Service,ServiceDto>().ReverseMap();
        }
    }
}
