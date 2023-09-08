using DecarotorPattern.Lab_1.Clients;
using DecarotorPattern.Lab_1.Concrete;
using DecarotorPattern.Lab_1.Interface;
using DecarotorPattern.Lab_2.Business.Concrete;
using DecarotorPattern.Lab_2.Model.Abstract;
using DecarotorPattern.Lab_2.Model.Concrete;
using System;

namespace DecarotorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lab 1
            IBilesen bilesen = new Bilesen();

            Client.Display("1. Ham hali => ", bilesen);
            Client.Display("2. Ham hali decaratör a dekore edildi sonuç => ", new DecaratorA(bilesen));
            Client.Display("3. Ham hali decaratör b dekore edildi sonuç => ", new DecoratorB(bilesen));
            Client.Display("4. Ham hali decaratör b ile sonra decoratör a ile dekore edildi sonuç => ", new DecaratorA(new DecoratorB(bilesen)));

            Client.Display(new DecoratorB(bilesen).EkDavranis().ToString(), new DecoratorB(bilesen));
            #endregion

            #region Lab 2
            CarBase myCar = new SUV
            {
                Brand = "Dodge",
                Model = "Ram 2500 Power Wagon",
                HirePrice = 35000
            };

            HireOffer hireOffer = new HireOffer(myCar);
            hireOffer.DiscountPercatege = 20;

            Console.WriteLine($"Not applied Discount: {myCar.HirePrice}");
            Console.WriteLine($"Applied Discount: {hireOffer.HirePrice}");

            #endregion


            Console.ReadKey();
        }
    }
}
