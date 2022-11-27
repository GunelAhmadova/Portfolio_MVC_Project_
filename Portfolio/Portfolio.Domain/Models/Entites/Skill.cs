using Portfolio.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models
{
    public class Skill: BaseEntity
    {
        public string SkillName { get; set; } 
        public string Description { get; set; } 
        public int Rate { get; set; }
        public string  SkillType { get; set; }
    }
}
