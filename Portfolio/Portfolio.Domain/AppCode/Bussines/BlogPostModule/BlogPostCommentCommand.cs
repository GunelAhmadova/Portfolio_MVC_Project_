using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entites;
using Portfolio.Domain.Models.Entites.Identity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Bussines.BlogPostModule
{
    public  class BlogPostCommentCommand:IRequest<BlogPostComment>
    {
        public string Comment { get; set; }
        public int BlogPostId { get; set; }


        public class BlogPostCommentCommandHandler : IRequestHandler<BlogPostCommentCommand, BlogPostComment>
        {
            private readonly PortfolioDbContext db;
            private readonly UserManager<AppUser> userManager;
            private readonly IHttpContextAccessor accessor;


            public BlogPostCommentCommandHandler(PortfolioDbContext db, UserManager<AppUser> userManager, IHttpContextAccessor accessor)
            {
                this.db = db;
                this.userManager = userManager;
                this.accessor = accessor;
            }
            public async Task<BlogPostComment> Handle(BlogPostCommentCommand request, CancellationToken cancellationToken)
            { 
                var blog=db.BlogPosts.Where(c=>c.Id==request.BlogPostId).FirstOrDefault();
                var comment= new BlogPostComment();
                comment.Comment = request.Comment;
                comment.BlogPostId = request.BlogPostId;
                comment.BlogPost=blog;
                var username = accessor.HttpContext.User.Identity.Name;
                var user = await userManager.FindByNameAsync(username);
                comment.AppUserId = user.Id;

                await db.BlogPostComments.AddAsync(comment);
                await db.SaveChangesAsync();

                return comment;

            }
        }
    }
}
