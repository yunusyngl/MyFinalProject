using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{   //Context : Db tabloları ile projede yer alan classları bağlamak için kullanılan bir class dır
    public class NorthwinContext :DbContext // burda tam olarak dememiz gereken benim veri tabanım burda yer alıyor demek
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // veri tabanının hangi tablo ile ilişkinin kurulacağı alan
        {
            // parantez içinde "/" kullanabilmek için @ başa yazdık
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true"); // burda sql server kullanacığımı belirtiyorum o vakit nasıl bağlanmak gerektiğini bildirmem lazım bunun için View menüsünden SQL Server Object Explorer da SQL server altındaki local adresi buraya yazıyoruz
            //Trusted_Connection=true dememizin sebebi kullanıcı adı ve şifre istemeden devam etsin
        }
        // veri tabanımın yerini belirtim ama hangi nesnem veri tabanında nesneyle eşleşecek şimdi alt kodlarda bunu belitrmemiz lazım
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
