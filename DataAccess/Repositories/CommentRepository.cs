﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entites.Concrete;

namespace DataAccess.Repositories
{
    public class CommentRepository:IGenericDal<Comment>
    {
        public void Add(Comment t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Comment t)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}