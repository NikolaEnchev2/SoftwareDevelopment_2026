using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write("Име:");
            string name = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Възраст: ");
            while (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine($"Невалидна възраст опитай пак");
        
            }
            Console.WriteLine();

            Console.Write("Клас: ");
            while(!((byte.TryParse(Console.ReadLine(), out byte clas) && (clas > 0 && clas <= 12))))
            {
              
                    Console.WriteLine("Няма как брат. Опитай пак");
                
            }
            Console.WriteLine();

            Console.Write("Среден успех: ");
            while (!(double.TryParse(Console.ReadLine(), out double grade) && (grade >= 2 && grade <= 6)))
            {
                Console.WriteLine("Няма как брат. Опитай пак");
            }

            Console.WriteLine();

            Console.Write("Въведете парична стойност: ");
            if(!decimal.TryParse(Console.ReadLine(), out decimal pari))
            {
                Console.WriteLine("Няма как брат. Опитай пак");
            }

            Console.WriteLine();

            Console.Write("Въведете паралелка: ");
            while(!(char.TryParse(Console.ReadLine(), out char letter) && (letter == 'А' || letter == 'Б' || letter == 'В' || letter == 'Г')))
            {
                Console.WriteLine("Няма как брат. Опитай пак");
            }
            Console.WriteLine();

            Console.Write("Въведете дата на раждане: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

        }
    }
}
