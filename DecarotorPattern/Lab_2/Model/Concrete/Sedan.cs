using DecarotorPattern.Lab_2.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecarotorPattern.Lab_2.Model.Concrete
{
    public class Sedan : CarBase
    {
        public override decimal HirePrice { get; set; }
    }
}
