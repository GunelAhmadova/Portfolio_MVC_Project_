using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.ServiceModule
{
    public class BackgroundRemoveCommand : IRequest<Background>
    {
        public int Id { get; set; }
        public class BackgroundRemoveCommandHandler : IRequestHandler<BackgroundRemoveCommand, Background>
        {
            private readonly PortfolioDbContext db;

            public BackgroundRemoveCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<Background> Handle(BackgroundRemoveCommand request, CancellationToken cancellationToken)
            {
                var Background = await db.Backgrounds.FirstOrDefaultAsync(sl => sl.Id == request.Id && sl.DeletedDate == null);

                Background.DeletedDate = DateTime.UtcNow.AddHours(4);

                await db.SaveChangesAsync(cancellationToken);
                return Background;
            }
    }
}
}
