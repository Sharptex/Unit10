using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit10
{
    public class Calc : ICalc
    {
        ILogger Logger { get; }

        public Calc(ILogger logger)
        {
            Logger = logger;
        }

        public decimal Sum()
        {
            Logger.Event("Начало метода");
            decimal number1 = GetNumberFromConsole("Введите первое слагаемое ");
            decimal number2 = GetNumberFromConsole("Введите второе слагаемое ");

            Logger.Event("Вывод результата");
            return number1 + number2;
        }

        decimal GetNumberFromConsole(string title)
        {
            decimal number = 0;
            bool res = true;
            while (res)
            {
                try
                {
                    Console.WriteLine(title);
                    string inputString = Console.ReadLine();
                    number = CheckNum(inputString);
                    res = false;
                }
                catch (FormatException ex)
                {
                    Logger.Error(ex.Message);
                }
                finally
                {
                    if (res)
                    {
                        Console.WriteLine("Попробуйте еще раз!");
                    }
                }
            }

            return number;
        }

        decimal CheckNum(string num)
        {
            if (decimal.TryParse(num, out decimal numToCheck))
            {
                return numToCheck;
            }
            else
            {
                throw new FormatException("Значение должно быть числом!");
            }
        }
    }
}
