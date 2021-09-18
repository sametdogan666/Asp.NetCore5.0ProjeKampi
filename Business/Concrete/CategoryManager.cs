using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository _efCategoryRepository;

        public CategoryManager()
        {
            _efCategoryRepository = new EfCategoryRepository();
        }
        public void Add(Category category)
        {
            _efCategoryRepository.Add(category);
        }

        public void Delete(Category category)
        {
            _efCategoryRepository.Delete(category);
        }

        public void Update(Category category)
        {
            _efCategoryRepository.Update(category);
        }

        public List<Category> GetAll()
        {
            return _efCategoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _efCategoryRepository.GetById(id);
        }
    }
}
