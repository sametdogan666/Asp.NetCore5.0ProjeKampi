using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore5._0ProjeKampi.ViewComponents.Comments
{
    public class CommentListByBlog :ViewComponent
    {
        CommentManager _commentManager = new CommentManager(new EfCommentRepository());

        public IViewComponentResult Invoke()
        {
            var results = _commentManager.GetAll(5);
            return View(results);
        }
    }
}
