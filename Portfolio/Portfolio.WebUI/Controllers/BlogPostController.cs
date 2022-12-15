using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.AppCode.Bussines.BlogPostModule;
using Portfolio.Domain.AppCode.Extension;
using Portfolio.Domain.Business.BlogPostModule;
using Portfolio.Domain.Models.DataContext;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Controllers
{
    public class BlogPostController : Controller
    {
        private readonly IMediator mediator;

        public BlogPostController(IMediator mediator)
        {
            this.mediator = mediator;
            
        }

       
        public async Task<IActionResult> Index(BlogPostPagedQuery query)
        {
            var response = await mediator.Send(query);
            response.Items = response.Items.Where(m => m.PublishDate != null && m.DeletedDate==null).ToList();
            if (Request.IsAjaxRequest())
            {
                return PartialView("_BlogsPartialView", response);
            }
            return View(response);
        } 

        public async Task <IActionResult> Detail(BlogPostSingleQuery query)
        {
            var allQuery = new BlogPostCommentAllQuery();
            allQuery.BlogPostId = query.Id; 
            ViewBag.comments=await mediator.Send(allQuery); 
            var response = await mediator.Send(query);
            return View(response);
        } 
        public async Task <IActionResult> PostComment(BlogPostCommentCommand command)
        {
            var response= await mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }

    }
}
