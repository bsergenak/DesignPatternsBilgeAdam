using DecarotorPattern.Lab_2.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecarotorPattern.Lab_2.Business.Abstract
{
    //CarDecoratorBase soyut sınıfnının CarBase.cs soyut sınıfından kalıtım almasını temin ettik. Burada dikkat edilemesi gereken husus CarBase.cs sınıfının abstract olarak işaretlenmiş "HirePrice" üyesinin burada override edilmeye zorunlu tutulmamasıdır. Bunun nedeni kalıtım alan ve veren sınıfların soyut olarak işaretlenmiş olmasıdır. Yani CarDecoratorBase.cs sınfııda soyut olduğundan atadan gelen kuralları uygulamak zorunda kalmadık.
    public abstract class CarDecoratorBase:CarBase
    {
        private CarBase _carBase;

        public CarDecoratorBase(CarBase carBase)
        {
            _carBase = carBase;
        }

    }
}
