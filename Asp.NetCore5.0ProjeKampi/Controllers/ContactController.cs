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
    public class ContactController : Controller
    {
        ContactManager _contactManager = new ContactManager(new EfContactRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.ContactCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            contact.ContactStatus = true;
            _contactManager.Add(contact);
            return RedirectToAction("Index","Blogs");
        }
    }
}
