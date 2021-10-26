using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entites.Concrete;

namespace Business.Abstract
{
    public interface IBlogService :IGenericService<Blog>
    {
        List<Blog> GetLast3Blog();
        List<Blog> GetAllWithCategory();
        List<Blog> GetBlogById(int id);
        List<Blog> GetBlogListByWriter(int id);
    }
}
