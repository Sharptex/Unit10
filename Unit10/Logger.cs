using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit10
{
    public class Logger : ILogger
    {
        public void Error(string messege)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(messege);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Event(string messege)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(messege);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
