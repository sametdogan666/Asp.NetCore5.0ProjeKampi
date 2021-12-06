using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;

namespace Asp.NetCore5._0ProjeKampi.Controllers
{
    [AllowAnonymous]
    public class BlogsController : Controller
    {
        BlogManager _blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var result = _blogManager.GetAllWithCategory();
            return View(result);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.id = id;
            var result = _blogManager.GetBlogById(id);
            return View(result);
        }

        public IActionResult BlogListByWriter()
        {
            var values =_blogManager.GetBlogListByWriter(1);
            return View(values);
        }
    }
}
