﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDispose
{
    internal class MyResourceWrapper : IDisposable
    {
        public void Dispose()
        {
            //Testing
            Console.WriteLine("******In Dispose!******");
        }
    }
}
