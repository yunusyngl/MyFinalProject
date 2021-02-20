using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IOrderDal :IEntityRepository<Order>// burda orders demedik orders demek ürünleri barındırır yani bir tablodur. Order ise her bir ürün için çalışır
    {

    }
}
