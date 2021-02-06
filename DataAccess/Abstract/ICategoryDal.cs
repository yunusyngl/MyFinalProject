using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal: IEntityRepository<Category> //"public interface ICategoryDal" için "IEntityRepository" i Category için yapılandırdın demek
    {
       /* List<Category> GetAll(); 
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);

        List<Category> GetAllByCategory(int categoryId);*/ 
    }
}
