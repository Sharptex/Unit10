﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit10
{
    public interface ILogger
    {
        void Event(string messege);
        void Error(string messege);
    }
}
