using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwinContext>, IProductDal//IProductDal demek veri tabanı ile ilgili işler yapılacak demek// bunların hepsi EfEntityRepositoryBase de var. bunları product ve NortwinContex için çalıştır
        // yani IProductDal diyor ki az önce kızdın ama bendeki özeliklerin hepsi EfEntityRepositoryBase de var o da beni inherit ediyor demek istiyor  
    {   //NuGet: paket kodların konulduğu yapı .Net içindeki EntityFramework 
        public List<ProductDetailDto> GetProductDetailDtos()
        {
            using (NorthwinContext context= new NorthwinContext())
            {
                var result = from p in context.Products//ürünlere p categorilere c deyip bunları join yapıyoruz 
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId // p deki categoryId iel c deki categoryId eşit ise bunları join yap
                             select new ProductDetailDto { ProductId = p.ProductId, ProductName = p.ProductName, CategoryName = c.CategoryName, UnitsInStock = p.UnitsInStock }; // seçilimi ilgili tabloların ilgili yerlerinden getir diyoruz burda
                return result.ToList();
            }
        }
    }
}
