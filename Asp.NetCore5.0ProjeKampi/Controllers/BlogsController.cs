using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace Asp.NetCore5._0ProjeKampi.Controllers
{
    public class BlogsController : Controller
    {
        BlogManager _blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var result = _blogManager.GetAllWithCategory();
            return View(result);
        }
    }
}
