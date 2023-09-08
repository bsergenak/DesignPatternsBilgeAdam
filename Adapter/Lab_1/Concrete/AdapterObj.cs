using Adapter.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Lab_1.Concrete
{
    public class AdapterObj : Uyarlayici, ITarget
    {
        public string Request(int i)
        {
            return $"Tahmini Sonuç : {Math.Round(SpecialRequest(i, 3))}";
        }
    }
}
