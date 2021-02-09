using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand entitiy)
        {
            throw new NotImplementedException();
        }

        public Brand Get(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Brand entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
