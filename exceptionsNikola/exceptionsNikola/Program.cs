using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionsNikola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 4;

            Console.WriteLine("Изчисляване на частно");
            try
            {
                int result = a / b;


                Console.WriteLine($"Резултат: {result}");

                Console.WriteLine("Изчислението приключи.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Грешка! Не може да се дели на О ");
            }

            Console.WriteLine("Край на програмата");
        }
    }
}
