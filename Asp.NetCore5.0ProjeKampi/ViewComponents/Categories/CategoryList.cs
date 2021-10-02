using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore5._0ProjeKampi.ViewComponents.Categories
{
    public class CategoryList:ViewComponent
    {
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var results = _categoryManager.GetAll();
            return View(results);
        }
    }
}
