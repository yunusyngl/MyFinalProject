using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {   // bir iş sınıfı başka sınıfları new lemez. bunun için injection yapıyoruz. Soyut nesne ile etkileşime gececez
        IProductDal _productDal;//injection // ampulden  generate constructor (yapı oluştur) productManager(productDal) -- yani productmanagerin altında productdal yapısı oluştur

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            //business codes
            _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            //İş kodlarını geçiyorsa veriye erişim vermeli
            //Yetkisi var mı? burda if kodları var diyelim ki geçti veri tabanına diyor ki bana ürünleri verebilirsin çünkü ben kurallardan geçtim

            return _productDal.GetAll(); // iş kodlarından geçiyorsa _productDal daki getAll ı çağırabilirsin
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice <=min && p.UnitPrice<= max);
        }

        public List<ProductDetailDto> GetProductDetailDtos()
        {
            return _productDal.GetProductDetailDtos();
        }

        void IProductService.Add(Product product)
        {
            throw new NotImplementedException();
        }
    }
}