using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using Business.ValidationRules.FluentValidation;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete;
using FluentValidation.Results;

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
            WriterValidator writerValidator = new WriterValidator();
            ValidationResult validationResult = writerValidator.Validate(writer);
            if (validationResult.IsValid)
            {
                writer.WriterStatus = true;
                writer.WriterAbout = "Deneme Test";
                _writerManager.Add(writer);
                return RedirectToAction("Index", "Blogs");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

        }
    }
}
