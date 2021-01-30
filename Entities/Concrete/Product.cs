using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity// bu class a diğer katmanlarda görsün diye class ın başına public yazdık // internal yazarsak class ın başına  o vakit sadece entites katmanı ulaşır
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitInStock { get; set; }//stok adedi
        public decimal UnitPrice { get; set; }


    }
}
