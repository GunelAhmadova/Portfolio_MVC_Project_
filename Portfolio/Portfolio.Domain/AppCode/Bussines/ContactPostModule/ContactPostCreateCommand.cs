using MediatR;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.ContactPostModule
{
    public class ContactPostCreateCommand: IRequest<ContactPost>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        public class ContactPostCreateCommandHandler : IRequestHandler<ContactPostCreateCommand, ContactPost>
        {
            private readonly PortfolioDbContext db;

            public ContactPostCreateCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<ContactPost> Handle(ContactPostCreateCommand request, CancellationToken cancellationToken)
            {
           
                var contactPost= new ContactPost();
                contactPost.Name = request.Name;
                contactPost.Email = request.Email;
                contactPost.Subject = request.Subject;
                contactPost.Message = request.Message;

                await db.ContactPosts.AddAsync(contactPost); 
                await db.SaveChangesAsync();    
                return contactPost;

            }
        }
    }
}
