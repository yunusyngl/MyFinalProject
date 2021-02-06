//using Entities.Abstract;
using Core.Entities;//Core değişikliği ile ekledik
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public string CustomerId { get; set; }
        public string ContactName { get; set; }// iletişim ismi

        public string CompanyName { get; set; }// şirket adı
        public string City { get; set; }

    }
}
