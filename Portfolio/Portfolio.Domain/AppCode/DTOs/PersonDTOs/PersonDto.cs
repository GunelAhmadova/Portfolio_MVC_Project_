﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.DTOs.PersonDTOs
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public string Experience { get; set; }
        public string Degree { get; set; }
        public string CareerLevel { get; set; }
        public string Phone { get; set; } 
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }  
        public string Bio { get; set; }
    }
}
