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












        public class PersonEditCommandHandler : IRequestHandler<PersonEditCommand, Person>
        {
            private readonly PortfolioDbContext db;
                public PersonEditCommandHandler(PortfolioDbContext db)
            {
                this.db = db;

                
            }
            public async Task<Person> Handle(PersonEditCommand request, CancellationToken cancellationToken)
            {
                var person = await db.People.FirstOrDefaultAsync( cancellationToken);

                person.Name = request.Name;
                await db.SaveChangesAsync();

                return person;
            }
        }
    }
}
