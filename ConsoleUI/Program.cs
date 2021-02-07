using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{

    //Burda yaptığımız işlem SOLID in O harfi --Open Closed Principle -- bu şe demek yaptığın yazılıma yeni bir özellik ekliyorsan mevcuttaki hiç bir koduna dokunamazsın --bizde sistemi InMemory yerine EntityFramework sistemine geçirdik -- yeni bir klasör oluşturup kendi kodlarını yazdık 
    class Program
    {
        static void Main(string[] args)
        {
             ProductTest();
            //Data Transformation Object 
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager();
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal()); // productManagerin efProductDal direk referans verdiği için direk new ile yazdık

            foreach (var product in productManager.GetProductDetailDtos()) // foreach yapısı ile git productManager daki ürünler içinden fiyatı 40 ile 100 arasındakileri getir
            {
                Console.WriteLine(product.ProductName +"/"+product.CategoryName);

            }
        }
    }
}
