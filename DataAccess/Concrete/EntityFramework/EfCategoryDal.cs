using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwinContext>, ICategoryDal// yani ICategoryDal diyor ki az önce kızdın ama bendeki özeliklerin hepsi EfEntityRepositoryBase de var o da beni inherit ediyor demek istiyor //bunların hepsi EfEntityRepositoryBase de var. bunları category  ve NortwinContex için çalıştır
    {
       
    }
}
