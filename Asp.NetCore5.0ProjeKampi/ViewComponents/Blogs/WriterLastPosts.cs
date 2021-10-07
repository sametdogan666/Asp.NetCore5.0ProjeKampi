using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore5._0ProjeKampi.ViewComponents.Blogs
{
    public class WriterLastPosts :ViewComponent
    {
        BlogManager _blogManager = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var results = _blogManager.GetBlogListByWriter(1);
            return View(results);
        }
    }
}
