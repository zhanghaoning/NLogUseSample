﻿using NLogSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new NLogTest();
            test.TestNLog();
            test.TestException();
        }
    }
}
