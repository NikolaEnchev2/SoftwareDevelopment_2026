using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Student
    {
        public int Id { get; }
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "" )
                    throw new ArgumentException("Името не може да е празно.");

                name = value;
            }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 6 || value > 20)
                    throw new ArgumentOutOfRangeException("Възрастта трябва да е между 6 и 20.");

                age = value;
            }
        }

        private int grade;
        public int Grade
        {
            get { return grade; }
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentOutOfRangeException("Класът трябва да е между 1 и 12.");

                grade = value;
            }
        }

        private double averageScore;
        public double AverageScore
        {
            get { return averageScore; }
            set
            {
                if (value < 2 || value > 6)
                    throw new ArgumentOutOfRangeException("Успехът трябва да е между 2 и 6.");

                averageScore = value;
            }
        }

        private decimal fee;
        public decimal Fee
        {
            get { return fee; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Таксата не може да е отрицателна.");

                fee = value;
            }
        }

        public bool HasScholarship { get; set; }

        private char classLetter;
        public char ClassLetter
        {
            get { return classLetter; }
            set
            {
                if (!char.IsLetter(value))
                    throw new ArgumentException("Паралелката трябва да е буква.");

                classLetter = value;
            }
        }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (value > DateTime.Today)
                    throw new ArgumentOutOfRangeException("Датата не може да е бъдеща.");

                birthDate = value;
            }
        }

        public Student(int id, string name)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException("Id трябва да е положително число.");

            Id = id;
            Name = name;
        }
    }





}

