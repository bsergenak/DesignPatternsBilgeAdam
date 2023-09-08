using DecarotorPattern.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecarotorPattern.Lab_1.Concrete
{
    public class DecaratorA : IBilesen
    {

        private IBilesen _bilesen;

        public DecaratorA(IBilesen bilesen)
        {
            _bilesen = bilesen;
        }

        public string Operation()=> _bilesen.Operation() + "yazılım tanımlı ağlar projesi geliştiriyorum.";
    }
}
