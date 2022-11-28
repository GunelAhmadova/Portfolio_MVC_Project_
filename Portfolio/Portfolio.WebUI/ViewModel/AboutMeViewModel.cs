using Portfolio.Domain.AppCode.DTOs.PersonDTOs;
using Portfolio.Domain.AppCode.DTOs.ServiceDTOs;
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.ViewModel
{
    public class AboutMeViewModel
    {
        public PersonDto  PersonDto { get; set; }
        public ICollection<ServiceDto> Services { get; set; }

        public ICollection<Skill> Skills { get; set; } 
   

        


    }
}
