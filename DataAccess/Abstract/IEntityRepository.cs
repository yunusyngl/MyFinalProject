using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{   // bu T yi sınırlandırmak istiyoruz
    // generic constraint -- cenerik kısıt
    // :class  bir refarans yani class yazavilirsiniz demek.
    // IEntity olabilir veya IEntity implemente eden bir class olabilr
    //new(): 
    public interface IEntityRepository<T> where T:class,IEntity,new()    
    {
        List<T> GetAll(Expression<Func<T,bool>> filter =null); // bütün hepsini filtreleyebildiği için altaki list yapısına gerek kalmaz
        T Get(Expression<Func<T, bool>> filter );
        void Add(T entity);
        void Update( T entity);
        void Delete( T entity);

        /*List<T> GetAllByCategory(int categoryId);*/
    }
}
