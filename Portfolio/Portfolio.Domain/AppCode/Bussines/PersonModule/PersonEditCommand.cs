using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.PersonModule
{
    public class PersonEditCommand: IRequest<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public string Experience { get; set; }
        public string Degree { get; set; }
        public string CareerLevel { get; set; }
        public string Phone { get; set; }
        public int Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Bio { get; set; } 



        public class PersonEditCommandHandler : IRequestHandler<PersonEditCommand,Person>
        {
            private readonly PortfolioDbContext db;

            public PersonEditCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
           
            public async Task<Person> Handle(PersonEditCommand request, CancellationToken cancellationToken)
            {

                var data = await db.People.FirstOrDefaultAsync(sl => sl.Id == request.Id && sl.DeletedDate == null, cancellationToken);

                if (data == null)
                {
                    return null;
                }

                data.Id = request.Id;
                data.Name = request.Name;
                data.Age = request.Age;
                data.Location = request.Location;
                data.Experiences = request.Experience;
                data.Degree = request.Degree;
                data.CareerLevel = request.CareerLevel;
                data.Phone = request.Phone;
                data.Fax = request.Fax;
                data.Email = request.Email;
                data.Website = request.Website;
                data.Bio = request.Bio;

                await db.SaveChangesAsync(cancellationToken);
                return data;
            }

           
        }
    }
}
