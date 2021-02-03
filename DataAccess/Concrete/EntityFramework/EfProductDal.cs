using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {   //NuGet: paket kodların konulduğu yapı .Net içindeki EntityFramework 
        private object contex;

        public void Add(Product entity)
        {
            using (NorthwinContext context = new NorthwinContext())// buradaki using IDısposable pattern implementation of c# -- belleği hızla temizlemeye yarar
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwinContext context = new NorthwinContext())// buradaki using IDısposable pattern implementation of c# -- belleği hızla temizlemeye yarar
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwinContext context = new NorthwinContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
            
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwinContext context=new NorthwinContext())
            {
                return filter == null
                    ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwinContext context = new NorthwinContext())// buradaki using IDısposable pattern implementation of c# -- belleği hızla temizlemeye yarar
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
