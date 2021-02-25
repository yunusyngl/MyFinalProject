using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {   // bir iş sınıfı başka sınıfları new lemez. bunun için injection yapıyoruz. Soyut nesne ile etkileşime gececez
        IProductDal _productDal;//injection // ampulden  generate constructor (yapı oluştur) productManager(productDal) -- yani productmanagerin altında productdal yapısı oluştur

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)// normalde "public void" idi burası bir tip döndürmüyor.. void döndürüyor. void demek ben özel bir tip döndürmüyorum
        {   //iki tırnak arasında yazdıklarımıza magic strings denir. genelde bu yazılar statik olduğundan her yere uymayabilir ve zamanla olmadık yerde karşımıza çıkar. bu magic stringler için Business katmanında "Constants" klasörü açıp burda bu işlemleri yapalım dedik
            if (product.ProductName.Length < 2) 
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            
            //business codes
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);//Projelerimizde başarı dönüşümlerin constractor ile yapacağız bu nedenle Result.cs de sadece get kullanıp kısıtladık. böylelikle kodların okunurluğu da artacaktır.
           
        }

        public IDataResult<List<Product>> GetAll() //IDataResult sonradan ekledik
        {
            //İş kodlarını geçiyorsa veriye erişim vermeli
            //Yetkisi var mı? burda if kodları var diyelim ki geçti veri tabanına diyor ki bana ürünleri verebilirsin çünkü ben kurallardan geçtim
            if (DateTime.Now.Hour==22) 
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult <List<Product>>( _productDal.GetAll(),Messages.ProductsListed); // iş kodlarından geçiyorsa _productDal daki getAll ı çağırabilirsin
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));//Success data içinde list product var ve onun constractorına parantez içini gönderiyorsun
        }

        public IDataResult<Product>GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));//Success data içinde list product var ve onun constractorına parantez içini gönderiyorsun
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice <= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {

            return new SuccessDataResult<List<ProductDetailDto>>(_productManager.GetProductDetailsDtos());
        }

        
    }


}