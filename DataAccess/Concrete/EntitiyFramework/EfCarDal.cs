﻿using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car car)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var addedEntity = context.Entry(car);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            } 
        }

        public void Delete(Car car)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(car);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car,bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }
        public List<Car> GetAll(Expression<Func<Car,bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ?
                    context.Set<Car>().ToList() :
                    context.Set<Car>().Where(filter).ToList();
                   
            }
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(car);
               updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
