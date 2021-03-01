using Core.DataAccess;
using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, NorthwindContext>, ICarImageDal
    {

    }
}
