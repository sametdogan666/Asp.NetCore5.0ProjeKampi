using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entites.Concrete;

namespace DataAccess.Repositories
{
    public class CategoryRepository :ICategoryDal
    {
        BlogContext _blogContext = new BlogContext();
        public List<Category> GetAll()
        {
            return _blogContext.Categories.ToList();
        }

        public void Add(Category category)
        {
            _blogContext.Add(category);
            _blogContext.SaveChanges();
        }

        public void Delete(Category category)
        {
            _blogContext.Remove(category);
            _blogContext.SaveChanges();
        }

        public void Update(Category category)
        {
            _blogContext.Update(category);
            _blogContext.SaveChanges();
        }

        public Category GetById(int id)
        {
            return _blogContext.Categories.Find(id);
        }
    }
}
