using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models.DataContext.Configuration
{
    internal class PersonEntityTypeConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            Person person = new()
            {
                Id = 1,
                Name = "Gunel",
                Age= 29,
                Email="gunelaa@code.edu.az",
                Location="Azerbaijan",
                Degree="Master",
                CareerLevel="Teacher",
                Phone="055-462-26-34",
                Website ="IGunel.com", 
            };
            builder.HasData(person);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(32);
            builder.Property(x=>x.CreatedDate).HasDefaultValue(DateTime.UtcNow);
            builder.Property(x => x.Phone).IsRequired();
        }
    }
}
