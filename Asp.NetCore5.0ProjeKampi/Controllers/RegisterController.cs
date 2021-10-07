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
    public class RegisterController : Controller
    {
        private WriterManager _writerManager = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            writer.WriterStatus = true;
            writer.WriterAbout = "Deneme Test";
            _writerManager.Add(writer);
            return RedirectToAction("Index", "Blogs");
        }
    }
}
