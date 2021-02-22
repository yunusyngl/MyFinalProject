using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T> //DataResulta diyoruz ki aslında sen bir Result sın diyoruz ama DataResult da diyorki onun constractor ları var bunları implemnte etmeliyiz
                                                       //ctor deyip iki tab yaptığımızda kısa yoldan sayfaya eklemiş olur
    {
        public DataResult(T data, bool success, string message): base(success, message)// constractor ekleyip neler vereceğimizi parantez içinde yazdık ---DataResult ın diğer Resultan tek farkı T data olduğunu unutma
        {                                                       // base de successi ve mesajı yollaması için ekledik 
            Data = data;
        }

        public DataResult(T data, bool success): base(success)// mesaju dışındakileri sadece göndermek istersekde bu kod bloğu çalışsın
        {
            Data = data;
        }
        public T Data { get; }
    }
}
