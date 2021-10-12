using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0ProjeKampi.Controllers
{
    public class ErrorPagesController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
