using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult: Result
    {   
        public ErrorResult(string message) : base(false, message)// Base ile kodun yazıldığı yer Result.cs gidip çift parametreli olanı çalıştıracak ona göre true false dönecek ve mesaj yazacak
        {

        }

        public ErrorResult() : base(false) //Base ile kodun yazıldığı yer Result.cs gidip parametresiz olanı çalıştıracak true veya false döndürecek
        {

        }

    }
}
