using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")] // bize nasıl istekte bulunalıcak ile ilgili ---bu isteği yaparken insanlar bize nasıl ulaşsın. controllerin başında api var. bu yüzden domainin başına api yazalım
    [ApiController]//Attributei diyoruz -- bir class ile ilgili  bilgi  verme ve onu imzalama yöntemidir
    public class ProductsController : ControllerBase// burda class a bir controller ile gelebileceğini belirtiyoruz burda 
    {   [HttpGet]
        public string Get()// get adında bir method veri türü string içinde return ile merhaba yazısını dönderiyor
        {
            return "Merhaba";// solda return ün izdişimine gelip tıkladığımızda çıkan işarete break point diyoruz
        }
        // yukarıdaki kodu çalıştırıdğımızda internet explorerde bize bir sonuç dönderir.bizim yukarıda bir productscontrollerimiz var ve Route bize bu isteği yaparken insanlar bize ulaşması için başına api yazsın şartı koymuş ve controllers ın ismini soruyor.. yukarıda parantez içinde görüldüğü gibi
        // ve internet explorerda açılan sayfada adres çubuğunda yer alan domainin yanına(https://localhost:44324/)-- buradaki localhost:44324 aslında kodlama.io gibi düşünebilirsin. bu domainin arkasına "api" ve controllerimizin ismi "products" yazalım .(https://localhost:44324/api/products) bunu çalıştırdığımızda break point içinde ok gibi turumcu şekil oluşur.
        // bu break pointin kırılım noktası demek yani kodlarımız buraya kadar geliyor mu gelmiyor mu bunun testi aslında. yani biz api/produts yazdığımızda bizim apimiz çalışıyor.
    }
}
