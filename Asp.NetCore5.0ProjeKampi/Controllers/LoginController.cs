using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Concrete;
using Entites.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace Asp.NetCore5._0ProjeKampi.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(Writer writer)
        {
            BlogContext blogContext = new BlogContext();
            var dataValue = blogContext.Writers.FirstOrDefault(x =>
                x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
            if (dataValue != null)
            {
                HttpContext.Session.SetString("usernama",writer.WriterMail);
                return RedirectToAction("Index", "Writer");
            }
            else
            {
                return View();
            }
            return View();
        }
    }
}
