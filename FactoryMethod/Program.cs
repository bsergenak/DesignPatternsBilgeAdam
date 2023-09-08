using FactoryMethod.Lab_1.Creator;
using FactoryMethod.Lab_1.Interface;
using FactoryMethod.Lab_2.Concrete;
using FactoryMethod.Lab_2.Creator;
using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lab 1
            ProductCreator productCreator = new ProductCreator();
            IProduct product;

            for (int month = 1; month <= 12; month++)
            {
                product = productCreator.FactoryMethod(month);
                Console.WriteLine($"Coffee Beans: {product.ShipFrom()}");
            }
            #endregion
            Console.WriteLine("================================== EX 2 ==================================== \n");
            #region Lab 2
            //Ctor Injection
            SystemManager plsLoggerManager = new SystemManager(new PLSLoggerFactory()); //bu injection türünde sınıfı her initialize ettiğimde injection otomatik olarak gerçekleşecektir. Ayrıca unutmayın sınıf veridiğimiz parametre ile inject edilecek!!!!

            SystemManager systemLoggerManager = new SystemManager(new SystemLoggerFactory());

            //Custom Method Injection
            //SystemManager plsLoggerManager = new SystemManager();
            //plsLoggerManagerçSystemManagerDI(new PLSLoggerFactory()); => injection bu method istediğimiz zaman, istediğimiz yerde gerçekleşecek.

            //property ınjection
            //SystemManager plsLogglerManager = new SystemManager();
            //plsLogger.SystemManagerDI = new PLSLoggerFactory(); => burada sınfıın üyesine değer atıyoruz. OOP'de hep yaptığımız gibi.....


            systemLoggerManager.Logged();
            plsLoggerManager.Logged();
            #endregion

            Console.ReadKey();
        }
    }
}
