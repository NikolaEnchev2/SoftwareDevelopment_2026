using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
        static int nextId = 1;
        static void Main(string[] args)
        {
            

            
            
                Student student = null;

                // Име
                while (student == null)
                {
                    try
                    {
                        Console.Write("Въведи име: ");
                        string name = Console.ReadLine();

                        student = new Student(nextId, name);
                        nextId++;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                // Възраст
                while (true)
                {
                    Console.Write("Въведи възраст: ");
                    int age;

                    if (int.TryParse(Console.ReadLine(), out age))
                    {
                        try
                        {
                            student.Age = age;
                            break;
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Въведи цяло число!");
                    }
                }

                // Клас
                while (true)
                {
                    Console.Write("Въведи клас: ");
                    int grade;

                    if (int.TryParse(Console.ReadLine(), out grade))
                    {
                        try
                        {
                            student.Grade = grade;
                            break;
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Въведи цяло число!");
                    }
                }

                // Среден успех
                while (true)
                {
                    Console.Write("Въведи среден успех: ");
                    double score;

                    if (double.TryParse(Console.ReadLine(), out score))
                    {
                        try
                        {
                            student.AverageScore = score;
                            break;
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Въведи число!");
                    }
                }

                // Такса
                while (true)
                {
                    Console.Write("Въведи такса: ");
                    decimal fee;

                    if (decimal.TryParse(Console.ReadLine(), out fee))
                    {
                        try
                        {
                            student.Fee = fee;
                            break;
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Въведи число!");
                    }
                }

                // Стипендия
                while (true)
                {
                    Console.Write("Получава ли стипендия? (да/не): ");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "да")
                    {
                        student.HasScholarship = true;
                        break;
                    }
                    else if (answer == "не")
                    {
                        student.HasScholarship = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Въведи да или не!");
                    }
                }

                // Паралелка
                while (true)
                {
                    Console.Write("Въведи паралелка: ");
                    string letter = Console.ReadLine();

                    if (letter.Length == 1)
                    {
                        try
                        {
                            student.ClassLetter = letter[0];
                            break;
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Въведи само една буква!");
                    }
                }

                // Дата на раждане
                while (true)
                {
                    Console.Write("Въведи дата на раждане (DD.MM.YYYY): ");
                    DateTime date;

                    if (DateTime.TryParse(Console.ReadLine(), out date))
                    {
                        try
                        {
                            student.BirthDate = date;
                            break;
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Невалидна дата!");
                    }
                }

                // Извеждане на данните
                Console.WriteLine("\n=== ДАННИ ЗА УЧЕНИК ===\n");

                Console.WriteLine($"Id:  {student.Id}");
                Console.WriteLine($"Име: {student.Name}");
                Console.WriteLine($"Възраст:  {student.Age}");
                Console.WriteLine($"Клас:  {student.Grade}");
                Console.WriteLine($"Среден успех:  {student.AverageScore}");
                Console.WriteLine($"Такса:  {student.Fee} евро.");
                Console.WriteLine($"Стипендия: " +  (student.HasScholarship ? "Да" : "Не"));
                Console.WriteLine($"Паралелка: {student.ClassLetter}");
                Console.WriteLine($"Дата на раждане:  { student.BirthDate}");
            }
        }
    }

