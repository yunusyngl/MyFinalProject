//using Entities.Abstract;
using Core.Entities;//Core değişikliği ile geldi
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity// bu class a diğer katmanlarda görsün diye class ın başına public yazdık // internal yazarsak class ın başına  o vakit sadece entites katmanı ulaşır
    {
        public int ProductId { get; set; } //prob tab tab
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }//UnitInStock:stok adedi,  short bir veri tipi int in bir küçüğü
        public decimal UnitPrice { get; set; } // decimal bir veri tipi para birimini tutuyoruz


    }
}
