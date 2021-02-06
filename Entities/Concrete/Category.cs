//using Entities.Abstract;
using Core.Entities;//Core değişikliği ile ekledik
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{   // Çıplak class kalmasın
    public class Category:IEntity // bu da bir diğer nesne 
    {   
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
