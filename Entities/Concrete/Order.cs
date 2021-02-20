using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Order:IEntity//IEntity implamente ediyoruz 
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeedId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }

    }
}
