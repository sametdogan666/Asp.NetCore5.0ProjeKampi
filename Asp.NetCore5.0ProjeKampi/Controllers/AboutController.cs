using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace Asp.NetCore5._0ProjeKampi.Controllers
{
    public class AboutController : Controller
    {
        AboutManager _aboutManager = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            var results = _aboutManager.GetAll();
            return View(results);
        }

        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
    }
}
