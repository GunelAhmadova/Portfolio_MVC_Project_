using MediatR;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Portfolio.Domain.AppCode.Bussines.PersonModule
{
    public class PersonAllQuery : IRequest<Person>
    {
        public class PersonAllQueryHandler : IRequestHandler<PersonAllQuery, Person>
        {
            private readonly PortfolioDbContext _db;
            public PersonAllQueryHandler(PortfolioDbContext db)
            {
                _db = db;
            }

            public async Task<Person> Handle(PersonAllQuery request, CancellationToken cancellationToken)
            {
                var person = await _db.People.FirstOrDefaultAsync(cancellationToken);
                return person;
            }
        }
    }
}
