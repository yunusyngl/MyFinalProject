//using Entities.Abstract;
using Core.Entities;// yeni değişiklikle geldi 
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess//DataAccess.Abstract
{   // bu T yi sınırlandırmak istiyoruz // T olarak veri tabanı nesnelerimiz gelsin :Category, Customer, Product gibi buna "generic constraint" -- cenerik kısıt bunu where : ile yapıyoruz. 
    // where:class  bir refarans tipi class olabilir diyor.. ama tekrar kısıtımızda sıkıntı yaşarız buraya her hangi bir class yazdığında da kod kabul edecektir. bu yüzden ikinci kısıtı koyuyoruz. Bunun için ", Entity" yapıyoruz
    // IEntity olabilir veya IEntity implemente eden bir nesne olabilr. şimdi oldu derken bir sıkıntı daha var biz buraya IEntity dediğimizde de kabul edecektir. Bunun için new() lenenbilir olmalı dersek artık IEntity kabul etmeyecektir.
    //new(): new lenebilir olmalı 
    public interface IEntityRepository<T> where T:class,IEntity,new()    
    {
        List<T> GetAll(Expression<Func<T,bool>> filter =null); // kodun ilk hali "List<T> GetAll()" böyleydi yani getAll ile bütün ürünlerin listeleme yapıyordu ..
        // Burada tümünü değilde istediğimiz kısmı getirmemize yarayan yapıya Experession diyoruz.. Böylece bütün hepsini filtreleyebildiği için altaki list yapısına gerek kalmaz
        // yani git category e göre filtrele yok product a göre filtrele tek tek yazmamıza gerek kalmayan yapı için Expression kullanırız
        T Get(Expression<Func<T, bool>> filter);// yukarıda getirdiğimiz ürünlerin herhangi birini alıp daha detayını görmemizi sağlar. yanlız yukarıdak koddan farklı olarak burda filter= null yapmıyoruz burada filtre zorunlu
        void Add(T entity);
        void Update( T entity);
        void Delete( T entity);

        /*List<T> GetAllByCategory(int categoryId);*/
    }
}
