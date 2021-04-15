using System;

namespace Unit10
{
    class Program
    {
        static ILogger Logger { get; set; }

        static void Main(string[] args)
        {
            Logger = new Logger();
            var calc = new Calc(Logger);

            Console.WriteLine("Сумма = {0}", calc.Sum());

            Console.ReadKey();
        }
    }
}
