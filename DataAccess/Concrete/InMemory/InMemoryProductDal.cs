using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {   
        // ben aşağıdaki list koduyla diyorum ki bu proje başladınca bellekte bir tane ürün listesi oluşturç
        List<Product> _products; //biz bu nesneyi bütün methodların dışında ama classın içinde tanımladığımızda bu tür değişkenlere globall değişken denir. Bu yüzden bunları ayırt edebilmek için alt çizgi ile veririz
        public InMemoryProductDal() // ctor yazıp tab tab yapalım. Constracter(yorum) bellekte referans aldığı zaman oluşacak olan çalışacak olan blog idi -- void falan yok direk class ın adıyla oluduğunda buna constracter deriz
        {   //sanki bir oracle ve sql server den geliyormuş gibi simule ediyoruz
            _products = new List<Product> // içinde bir sürü ürün oluşturduk 
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150, UnitsInStock=65},
                new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85, UnitsInStock=1},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {   //LINQ -language Integrated Query
            
           /* Product productToDelete = null; // null dedik ilk başta herhangi bir referansı yok yoksa hata verir
            foreach (var p in _products) // burası tüm ürünleri dolaşmaya yarar
            {
                if(product.ProductId==p.ProductId) // productaki  productID ile p deki ProductID eşleşirse git bu productID yi sil diyoruz
                {
                    productToDelete = p;
                }
            }*/
            //SingleOrDefault : tek bir eleman bulmaya yarar.. bu yapı product ı tek tek dolaşmaya yarar.. "=>" bu işarete lambda deniyor. aşağıdaki LINQ kodu yukarıdaki kod yerine yazılmıştır.
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);// Burda yukarıdaki formulü LINQ(Language Integrated Query)-(dile gömülü sorgulama) ile yazdık aslında. LINQ C# ı diğer dilerden daha güçlü hale getiren bir yapıdır. LINQ ile yukarıdaki liste yapılı yapıları aynen sql gibi sorgulayabiliriz

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {   // Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul ki onu güncelleyelim

            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;


        }

        public List<Product>GetAllByCategory(int categoryId) 
        {
            return _products.Where(p => p.CategoryId==categoryId).ToList(); // where içindeki şarta uyan bütün elemanları yeni bir liste haline getirip onu döndürür  
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetailDtos()
        {
            throw new NotImplementedException();
        }
    }
}
