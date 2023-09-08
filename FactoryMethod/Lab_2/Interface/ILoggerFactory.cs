﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Lab_2.Interface
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }
}
