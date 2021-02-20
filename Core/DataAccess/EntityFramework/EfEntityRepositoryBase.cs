using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    //public class EfEntityRepositoryBase<TEntity,TContext>: burda inherit yapmamız lazım çünkü IEntityRepository temel fonksiyonların imzası vardı biz bu sınıfa gelip bu methodları implemante et diyoruz. daha sonra IEntityRepository i çözelim  
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity> // yani diyorum ki buraya kafana göre her classı yazamazsın DbContext den inherit edilmesi lazım
        where TEntity: class, IEntity, new() // TEntity için kısıtlar koyalım --bu bir veri tabanı tablosu olacak bir referans tip olacak ama IEntity yazamayız diye new liyorduk burda
        where TContext: DbContext,new()//TContext için kısıtlama koyalım-- bu arkadaşımız DbContext olmalı // daha sonra da DbContext e gelip bunu EntityFrameworkCore den çözelim
    { 
        //private object contex;

        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())// buradaki using IDısposable pattern implementation of c# -- belleği hızla temizlemeye yarar
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())// buradaki using IDısposable pattern implementation of c# -- belleği hızla temizlemeye yarar
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }

        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())// buradaki using IDısposable pattern implementation of c# -- belleği hızla temizlemeye yarar
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
