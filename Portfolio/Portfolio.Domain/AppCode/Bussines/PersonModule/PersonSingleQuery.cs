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
    public class PersonSingleQuery : IRequest<Person>
    {
        public int Id { get; set; }
        public class PersonSingleQueryHandler : IRequestHandler<PersonSingleQuery, Person>
        {
            private readonly PortfolioDbContext _db;
            public PersonSingleQueryHandler(PortfolioDbContext db)
            {
                _db = db;
            }

            public async Task<Person> Handle(PersonSingleQuery request, CancellationToken cancellationToken)
            {
                var person = await _db.People.FirstOrDefaultAsync(x=>x.Id==request.Id,cancellationToken);
                return person;
            }
        }
    }
}
