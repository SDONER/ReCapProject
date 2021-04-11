using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
   public class EfBankDal : EfEntityRepositoryBase<Bank, NorthwindContext>,IBankDal
   {  
   }
}

