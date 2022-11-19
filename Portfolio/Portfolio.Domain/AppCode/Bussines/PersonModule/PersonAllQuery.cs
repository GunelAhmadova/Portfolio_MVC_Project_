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
using AutoMapper;
using Portfolio.Domain.AppCode.DTOs.PersonDTOs;

namespace Portfolio.Domain.AppCode.Bussines.PersonModule
 
{
    public class PersonAllQuery : IRequest<PersonDto>
    {
        
        public class PersonAllQueryHandler : IRequestHandler<PersonAllQuery, PersonDto>
        {

            private readonly IMapper mapper;
            private readonly PortfolioDbContext _db;
            public PersonAllQueryHandler(PortfolioDbContext db, IMapper mapper)
            {
                _db = db;
                this.mapper = mapper;
            }

            public async Task<PersonDto> Handle(PersonAllQuery request, CancellationToken cancellationToken)
            {
                var person = await _db.People.FirstOrDefaultAsync(cancellationToken);
                var personDto = mapper.Map<PersonDto>(person);
                
                return personDto;
            }
        }
    }
}
