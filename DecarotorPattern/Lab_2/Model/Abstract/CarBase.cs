using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecarotorPattern.Lab_2.Model.Abstract
{
    public abstract class CarBase
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        
        public abstract decimal HirePrice { get; set; }
    }
}
