﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunar
{
    class Lunar
    {
        public static void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("{");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Lunar");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("} " + message + "\n");
        }

        public static void LogNoBreak(string message)
        {
            ConsoleColor old = Console.ForegroundColor;
            Console.Write("{");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Lunar");
            Console.ForegroundColor = old;
            Console.Write("} " + message);
        }
    }
}
