using Core.DataAccess;// Core değişikliği ile geldi
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{   //interface public değil ama operasyonları yani add, update, delete bunlar publix
    public interface IProductDal : IEntityRepository<Product> // "public interface IProductDal" için "IEntityRepository" i product için yapılandırdın demek
    {
        // aşağıdaki satırda product farklı bir katmanda olduğundan eklediğimizde altı çizili gelecektir. Bu tablo hangi katmanda ise onu referans göstermeliyiz.
        // Bu yüzden solda çıkan ampule tıkla -- Add referance to Entities--Using Entities.Concrete;  // kısacası başka katmanı kullanacaksak referans veririz
        // Yukarıda solda çıkan ampulden otamatik olarak eklenmezse --DataAccess sağ tıkla--Project Referance-- açılan ekrandan DataAccess hangi katmanı kullanacaksa onu işeretleyelim(Entities)-- burda hepsini seçip birbirine referans verirsek sonsuz döngü olur. işimize yaramayan katmanı referans vermemeye dikkat edelim.
        // şimdi tekrar Product-- ampul-- using Entities.Concrete -- artık kendi içindeymiş gibi referans verir sayfanın üstünde 
        /*List<Product> GetAll(); //Örneğin ürün listeleyecem yani e ticaret sitesindeki tüm ürünlerin listelendiğini düşün ve biz buna GetAll diyecez. Get:getir çek All : hepsini -- yani hepsini çek getir
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId); // bütün ürünleri categorilere göre filtrele*/

        List<ProductDetailDto> GetProductDetailDtos();
    }
}
