using Business.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll(); // yani tüm ürünleri listeleyecek bir ortam oluşturalım
        List<Product> GetAllByCategoryId(int Id);

        List<Product> GetByUnitPrice(decimal min, decimal max);

        List<ProductDetailDto> GetProductDetailDtos(); // daha sonrdan Entity katmanına eklediğimiz DTOs klasörü altındaki ProductDetailDto.cs  değişikliği eklediğimizden burada IProductService deki nesneleride burda listelemek için yazdık. Bunu hemen çözümleyelim
                                                       //Değişiklik yaptığımızdan bu interface kullanan Concrete dosyası altındaki çalışmaları implement etmeyi unutmayalım

        Product GetById(int productId);// bizim için sadece product dönderiyor-- tek başına bir ürün dönderiyor yani liste döndermiyor

        IResult Add(Product product);// yeni bir ürün ekleyebilmek için yazdık -- bişey döndürmüyor "void Add" void söz konusu burayı IResult yapalım burda sonuç dönderelim -- yani void olan yerlere IResult diyecem bundan sonra

    }
}
