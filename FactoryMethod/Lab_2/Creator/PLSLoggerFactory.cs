﻿using FactoryMethod.Lab_2.Concrete;
using FactoryMethod.Lab_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Lab_2.Creator
{
    public class PLSLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger() => new PLSLogger();
    }
}
