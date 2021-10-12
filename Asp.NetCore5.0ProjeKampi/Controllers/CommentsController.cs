using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete;

namespace Asp.NetCore5._0ProjeKampi.Controllers
{
    public class CommentsController : Controller
    {
        CommentManager _commentManager = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            comment.CommentCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            comment.BlogId = 2;
            _commentManager.CommentAdd(comment);
            return PartialView();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var results = _commentManager.GetAll(id);
            return PartialView(results);
        }
    }
}
