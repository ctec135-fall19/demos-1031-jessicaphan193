﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Linq;
using static System.Console;

namespace MyMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("101 + 99 = {0}", MyMath1.Add((byte)101, (byte)99));
            Console.WriteLine("101 + 201 = {0}", MyMath1.Add((byte)101, (byte)201));
        }
    }
}
