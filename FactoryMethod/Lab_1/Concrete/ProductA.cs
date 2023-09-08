using FactoryMethod.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Lab_1.Concrete
{
    public class ProductA : IProduct
    {
        public string ShipFrom() => "from South Africa...!";
    }
}
