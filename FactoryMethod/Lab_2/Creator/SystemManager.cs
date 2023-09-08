using FactoryMethod.Lab_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Lab_2.Creator
{
    public class SystemManager
    {
        private ILoggerFactory _loggerFactory;

        //Custom Method DI => Constructor ile DI yaptığımızda SystemManager.cs sınıfı initialize ettiğimiz yerde otomatik olarak DI gerçekleşiyordu. Lakin DI türleri bulunmaktadır.
        //Bunlar:
        //1.Constructor Injection => Constructor injection'da ilgili sınıf initialize edildiğinde injection işlemi otomatik olarak gerçekleşir. BU senaryoda ilgili sınıfı new'lediğimiz her yerde inject edeceği sınıfı parametre olarak vermemiz gerekmektedir. Bu hususu göz önünde bulundurarak tercih etmeliyiz.
        //2.Custom Method Injection => Bu injection türünde, bir instance fonksiyon aracılığıyla injection gerçekleştirilir. Bu yöntemi seçerek şu hususu göz önünde bulundurmalıyız. İlgili sınıfımızı new'lerken injection gerçekleştirmek istemiyorsak ve injection bizim ihityacımız olduğu anda gerçekleşmesini istiyorsak kullanmalıyız. 
        //3.Property Injection => Bu injection türünde ise ilgili sınıfın bir property member'ı üzerinden yüm injection ilşemi yerine getirilir. Böylelikle property'lerin get; set; mekanizmaları üzerinden injection işlemlerimi yerine getireceğim.

        //Constructor Injection
        public SystemManager(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        //Custom Method Injection
        //public ILoggerFactory SystemManagerDI(ILoggerFactory loggerFactory) => _loggerFactory = loggerFactory;

        //Property Injection
        //public ILoggerFactory SystemManagerDI
        //{
        //    get { return _loggerFactory; }
        //    set { _loggerFactory = value; }
        //}

        public void Logged() => _loggerFactory.CreateLogger().Log();
    }
}
