using SingletonPattern.Lab_1;
using SingletonPattern.Lab_2;
using System;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lab 1
            //Aşağıdaki kodu aktifleştirdiğimizde Ctor bize kızdı, çünkü erişilebilir değil. Teorik olarakta tartışmıştır, singleton ile üretilen nesneleri uygulamnın herhangi bir yerinde çağırabiliriz, yeniden üretemeyiz.
            //SystemManager systemManager = new SystemManager();
            SystemManager systemManager = SystemManager.CreateSingletonObject();

            //Bu custom method vasıtasıyla bir SystemManager.cs sınfıından bir nesne sınfıın içerisinde kontrollü bir şekilde üretilecek bve bize burada geri döndürülecek.

            systemManager.CreateLog();//SystemManager değişkeni üzerinden SystemManager.cs sınfıı içersinde olan CreateLog() methoduyna eriştim. Normalde bu method instance method olduğundan ona nesnenin örneklemi üzerinden erişebildim.
            #endregion

            #region Lab_2
            Console.WriteLine($"Sonuç: {SingletonClass.SingleObject.Toplam(2,3)}");

            Console.WriteLine($"Sonuç: {SingletonClass.SingleObject.Toplam(2, 3)}");

            #endregion

            Console.ReadKey(); //Console ekranının  görevini icra ettikten sonra bizden bir komut beklemesi için bunu kullandık. Aslında Console ekranı kapansamın diye yapıyoruz.
        }
    }
}
