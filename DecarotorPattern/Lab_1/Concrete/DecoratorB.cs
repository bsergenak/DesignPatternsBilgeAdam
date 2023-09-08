using DecarotorPattern.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecarotorPattern.Lab_1.Concrete
{
    public class DecoratorB : IBilesen
    {

        private IBilesen _bilesen;

        public DecoratorB(IBilesen bilesen)
        {
            _bilesen = bilesen;
        }

        public string Operation() => _bilesen.Operation() + "RPA projeleri geliştiriyorum.";

        public string EkDavranis() => "Yüksek lisans yapıyorum";
    }
}
