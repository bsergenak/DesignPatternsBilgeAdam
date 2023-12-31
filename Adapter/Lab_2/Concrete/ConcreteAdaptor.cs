﻿using Adapter.Lab_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Lab_2.Concrete
{
    public class ConcreteAdaptor : IHedef
    {
        private Bagdastirici _bagdastirici;

        public ConcreteAdaptor(Bagdastirici bagdastirici)
        {
            _bagdastirici = bagdastirici;
        }

        public string GetRequest() => $"{_bagdastirici.GetSpesificRequest()}";
    }
}
