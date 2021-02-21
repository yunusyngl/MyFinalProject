using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{   //Temel voidler için başlangıç --Yani voidleri IResults yapısı ile süslüyor olacaz 
    public interface IResult //içinde bir tane işlem sonucu olsun bir tane de kullanıcıyı bilgilendirmek adına mesaj olsun. bizim uygulamayı(API) kullancak kişilerin doğru yönklendirmeyi amaçlayalım
    {
        bool Success { get; } //yani yapmaya çalıştığınm  ekleme işi başarılı ise true değilse false  çalıştırır
        // get sadece okunabilir demek..propertiler bizim için iki noktada önemliydi biri get (okumak)ler diğeri set (yazmak) ler için 
        string Message { get; }// yapmaya çalıştığımız işlem true ise kullanıcı ise ürün başarıyla eklenmiştir şeklinde bilgi verir 

    }
}
