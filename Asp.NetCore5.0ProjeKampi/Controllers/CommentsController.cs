using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace Asp.NetCore5._0ProjeKampi.Controllers
{
    public class CommentsController : Controller
    {
        CommentManager _commentManager = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var results = _commentManager.GetAll(id);
            return PartialView(results);
        }
    }
}
