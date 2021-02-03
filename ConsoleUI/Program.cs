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
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach ( var product in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(product.ProductName);

            }
        }
    }
}
