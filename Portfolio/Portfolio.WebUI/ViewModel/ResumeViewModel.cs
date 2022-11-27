using Portfolio.Domain.AppCode.DTOs.PersonDTOs;
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.ViewModel
{
    public class ResumeViewModel
    {
        public PersonDto Person { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<Background> Backgrounds { get; set; }
    }
}
