using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{   //SOLID : Bu yaptığımız yazılıma yeni bir özellik ekliyorsak mevcuttaki hiçç bir koda dokunmazsın ama biz bunu EntityFramework ile yaptık 
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal()); // productManagerin efProductDal direk referans verdiği için direk new ile yazdık

            foreach ( var product in productManager.GetByUnitPrice(40,100)) // foreach yapısı ile git productManager daki ürünler içinden fiyatı 40 ile 100 arasındakileri getir
            {
                Console.WriteLine(product.ProductName);

            }
        }
    }
}
