using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.AppCode.DTOs.PersonDTOs;
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
    public class PersonEditCommand: IRequest<PersonDto>
    {
        public PersonDto person;

        public class PersonEditCommandHandler : IRequestHandler<PersonEditCommand, PersonDto>
        {

                private readonly PortfolioDbContext db;
                private readonly IMapper mapper;
            public PersonEditCommandHandler(PortfolioDbContext db, IMapper mapper)
            {
                this.db = db;
                this.mapper = mapper;
            }
            public async Task<PersonDto> Handle(PersonEditCommand request, CancellationToken cancellationToken)
            {
                var personDto = request.person;
                var edited= mapper.Map<Person>(personDto);
                db.Entry(edited).State = EntityState.Modified;
                await db.SaveChangesAsync();
                
                return request.person;
            }
        }
    }
}
