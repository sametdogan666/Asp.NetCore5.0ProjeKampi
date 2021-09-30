using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entites.Concrete;

namespace DataAccess.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        List<Blog> GetAllWithCategory();
    }
}
