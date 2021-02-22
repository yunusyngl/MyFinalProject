using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string message):base(data,true,message)// bu versiyonda data ve mesaj ver 
        {
             
        }

        public SuccessDataResult(T data):base(data,true)// mesaj olayına girmek istemediğinde sadece data ver versiyonu
        {

        }

        public SuccessDataResult(string message):base(default, true, message)// sadece mesaj döndermek istiyorsak 
        {

        }

        public SuccessDataResult():base(default,true)// bu versiyonda hiç bir şey vermeyor
        {

        }
    }

}
