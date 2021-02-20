using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal; //Normalde business katmanı veri erişimine bağlı ama veri erişimde entityFramework olur yarın NI.net olur başka bişey olur bu yüzden bağımlılığımızı minimize ediyoruz. ICategoryDal lazım diyorum bana onu using ile çözüyoruz. bağımlılığımı constructor injection ile kaldırıyorum.
                                   //constructor injection(“Dependency Inversion”):S.O.L.I.D prensiplerinin 5. ayağını oluşturan “Dependency Inversion” prensibinin uygulanmasını içeren bir patterndir.Sağlıklı, esnek ve genişletilebilir bir proje için mümkün olduğunca bağımlılıklar azaltılmalı ve yönetilebilir olmalıdır.
                                   //_categoryDal ı injection yapmak için soldaki ampulden Generate Constructor otomatil olarak geliyor.. bu şu demek ben CategoryManager olarak veri erişim katmanına bağlıyım ama biraz zayıf bağımlılığım var. Çünkü interface üzerinden referans üzerinden bağımlıyım. Bu nedenle DataAccess katmnanında istediğin değişikliği rahatlıkla yapabilirsin artık.
        public CategoryManager()
        {
        }

        public  CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;

        }
        public List<Category> GetAll()
        {
            //iş kodları
            return _categoryDal.GetAll();// categorydall daki tüm bilgileri bana getir
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);// categorydal da c ( c= categorinin c si aslında veri tabanına soruyor)için c nin CategoryId si benim gönderdiğim categoryId ye eşit ise getir. aslında bir sql sorgusu gibi düşünebiliriz. select*from Categories where CategoryId=3 gibi düşünebiliriz
        }
    }
}
