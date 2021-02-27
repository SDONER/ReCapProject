using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IResult Add(Category category);
        IResult Delete(Category category);
        IResult Update(Category category);  
        IDataResult<List<Category>> GetAll();
        IDataResult<List<Category>> GetById(int categoryId);
    }
}