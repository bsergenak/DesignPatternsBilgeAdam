using Adapter.Lab_1.Concrete;
using Adapter.Lab_1.Interface;
using Adapter.Lab_2.Concrete;
using Adapter.Lab_2.Interface;
using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lab1
            Uyarlayici uyarlayici = new Uyarlayici();
            Console.WriteLine(uyarlayici.SpecialRequest(5, 3));

            ITarget target = new AdapterObj();
            Console.WriteLine(target.Request(5));

            #endregion


            #region Lab 2
            Bagdastirici bagdastirici = new Bagdastirici();

            IHedef hedef = new ConcreteAdaptor(bagdastirici);

            Console.WriteLine("Bagdastırıcı arayüz istemci ile uyumsuz..!");
            Console.WriteLine("Ancak concrete adaptör istemcisi bu yöntemi çağırabilir.");
            Console.WriteLine(hedef.GetRequest());
            #endregion

            Console.ReadKey();
        }
    }
}
