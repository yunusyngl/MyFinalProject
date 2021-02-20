using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDetailDto: IDto // Çıplak join kalmasın demiştik ama buraya IEntity diyemeyiz çünkü burası birden fazla tablonun joini olabilir bu yüzden buraya IDto dedik.
                                        //IDto ayne Core katmanındaki IEntity gibi buda evrensel bir interface bu nedenle ampulu tıklayalım. burdan Generate type IDto üstüne geldiğimde --Generate New Type tıkla--açılan ekrandan daha önce oluşturmadığımız burda direk isim verdiğimiz IDto interfacein özeliklerini belirleyip oluşturabiliriz.
                                        //Access:public, Kind:İnterface, Name:IDto yeri ise Projuct:Core -- create New file secili hale getirip yani Core katmanın altında bir dosya olsun istiyoruz. bu yüzden bu alana Entities\IDto.cs yazalım. daha sonra IDto yanındaki ampulden using yapıp çözelim. yukarıya gelen using dikkat edelim "using Core.Entities;" şeklinde olmalıdır. Sonuna Entities yoksa ekleyelim
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }

    }
}
