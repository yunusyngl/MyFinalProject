using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)// bu versiyonda data ve mesaj ver 
        {

        }

        public ErrorDataResult(T data) : base(data, false)// mesaj olayına girmek istemediğinde sadece data ver versiyonu
        {

        }

        public ErrorDataResult(string message) : base(default, false, message)// sadece mesaj döndermek istiyorsak 
        {

        }

        public ErrorDataResult() : base(default, false)// bu versiyonda hiç bir şey vermeyor
        {

        }
    }
}
