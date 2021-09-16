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
    public class BlogRepository : IBlogDal
    {

        public List<Blog> GetAll()
        {
            using var _blogContext = new BlogContext();
            return _blogContext.Blogs.ToList();
        }

        public void Add(Blog blog)
        {
            using var _blogContext = new BlogContext();
            _blogContext.Add(blog);
            _blogContext.SaveChanges();
        }

        public void Delete(Blog blog)
        {
            using var _blogContext = new BlogContext();
            _blogContext.Remove(blog);
            _blogContext.SaveChanges();
        }

        public void Update(Blog blog)
        {
            using var _blogContext = new BlogContext();
            _blogContext.Update(blog);
            _blogContext.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var _blogContext = new BlogContext();
            return _blogContext.Blogs.Find(id);
        }
    }
}
