using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();// tümünü listeler
        Category GetById(int categoryId); // bir kategorinin ıd ni vereyim sen bana bunun detayını ver demek istedik

    }
}
