﻿using FactoryMethod.Lab_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Lab_2.Concrete
{
    public class SystemLogger : ILogger
    {
        public void Log() => Console.WriteLine("System information was logged..!");
    }
}
