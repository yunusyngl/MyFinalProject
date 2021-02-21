using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //private bool v1;
        // private string v2;

        public Result(bool success, string message) : this(success) // burda this demek rusult ın kendisidir. yani result classı içinde bulunan success metheodu çalıştır dedik
         // burda işlem sonucunun true veya falce ile birlikte mesajda dönderir
        {
            //this.v1 = v1;
            // this.v2 = v2;
            Message = message;
          
        }

        public Result(bool success) // burda sadece işlem sonucunun true veya falce olduğu döner
        {          
            Success = success;
        }

        public bool Success  { get; }  // biz constractor dışında set etmiyecez bu nedenle get kullandık ki tamamen constractor yapısı ile kullanılsın

        public string Message { get;}

    }
}
