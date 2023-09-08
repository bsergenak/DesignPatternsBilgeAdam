using DecarotorPattern.Lab_2.Business.Abstract;
using DecarotorPattern.Lab_2.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecarotorPattern.Lab_2.Business.Concrete
{
    //HireOffer.cs sınıfı CarDecoratorBase.cs soyut sınıfından kalıtım aldı. Kalıtım vasıtasıyla implement edilmesi zorunlu olarak gelen HirePrice üyesinin burada override ettik. Bunun yanında ctor yapısında aşığada dokümante edildiği gibi aldığı parametreyide atasına gönderdik.
    public class HireOffer : CarDecoratorBase //HireOffer arabirimdir.
    {
        private CarBase _carBase;
        //HireOffer.cs sınıfını initialize ettiğimizde ctor methodu içeriisnde zorunlu olarak "CarBase" tipinde bir parametre verdik. Lakin kızgınlığı geçmedi, bunun sebebi atasınında bu parametreyi beklemesinid. Bu kapsamda ctor methodun yanına "base(carBase)" değerinide ekledik ki sınıflar initialize edilirken gelen parametre her iki tarafta da kullanılabilsin. Böylelikle gelen parmaetrei hem HireOffer.cs içeriisnde kullanabileceğiz hemde atasına da gönderebileceğiz.
        public HireOffer(CarBase carBase) : base(carBase)
        {
            _carBase = carBase;
        }

        //Sınıf içerisinde kullanılacak olan üye,
        public int DiscountPercatege { get; set; }

        public override decimal HirePrice 
        { 
            get => _carBase.HirePrice * DiscountPercatege / 100; 
            set { }
        }
    }
}
