using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntitiyRepository<T> where T:class,IEntities,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter = null);
        List<T> GetById();
        void Add(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);

        //List<Category> GetByAllBrandId(int Id);
    }
}
