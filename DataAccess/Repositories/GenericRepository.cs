using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete;

namespace DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T t)
        {
            using var _blogContext = new BlogContext();
            _blogContext.Add(t);
            _blogContext.SaveChanges();
        }

        public void Delete(T t)
        {
            using var _blogContext = new BlogContext();
            _blogContext.Remove(t);
            _blogContext.SaveChanges();
        }

        public void Update(T t)
        {
            using var _blogContext = new BlogContext();
            _blogContext.Update(t);
            _blogContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var _blogContext = new BlogContext();
            return _blogContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var _blogContext = new BlogContext();
            return _blogContext.Set<T>().Find(id);
        }
    }
}
