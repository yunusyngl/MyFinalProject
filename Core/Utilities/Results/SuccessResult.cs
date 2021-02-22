using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult: Result
    {
        public SuccessResult(string message) : base(true, message)// Base ile kodun yazıldığı yer Result.cs gidip çift parametreli olanı çalıştıracak ona göre true false dönecek ve mesaj yazacak
        { 
        
        }

        public SuccessResult(): base(true) //Base ile kodun yazıldığı yer Result.cs gidip parametresiz olanı çalıştıracak true veya false döndürecek
        { 
        
        }
    }
}
