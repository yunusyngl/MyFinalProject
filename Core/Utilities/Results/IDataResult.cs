using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult// T hangi tipi döndereceğini bize söylemesi için yazdık 
    {
        T Data { get; } // mesaj veya true false dışında birde T adında bir data olacak. o data da şu an örneğin ürünlerimiz olabilir
    }
}
