using System;
using System.Collections.Generic; //используется для динамического массива

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string m1 = "1. Одномерные массивы.";
            string m2 = "2. Двумерные массивы.";
            string m3 = "3. Динамические массивы.";
            string successfully = "Выполнение программы: ";
            string air = ""; //чтобы при выводе было красиво

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);

            Console.WriteLine(air);

            Console.WriteLine("Введите номер:");

            String input = Console.ReadLine();

            Console.WriteLine(air);

            if (int.TryParse(input, out int selectedOption))
            {
                switch (selectedOption)
                {
                    case 1:
                        Console.WriteLine(successfully + m1);
                        Console.WriteLine(air);
                        Main1();
                        Console.ReadKey(); //нужно чтобы не закрывалось окно
                        break;
                    case 2:
                        Console.WriteLine(successfully + m2);
                        Console.WriteLine(air);
                        Main2();
                        Console.ReadKey(); //нужно чтобы не закрывалось окно
                        break;
                    case 3:
                        Console.WriteLine(successfully + m3);
                        Console.WriteLine(air);
                        Main3();
                        Console.ReadKey(); //нужно чтобы не закрывалось окно
                        break;
                }

            }
            else
            {
                Console.WriteLine("Ошибка, вы ввели номер не из списка.");
            }
        }
        //Одномерные массивы
        static void Main1()
        {
            byte[] digits = new byte[5];

            digits[0] = 34;
            digits[4] = 255;

            Console.WriteLine(digits[3]);

            string[] students = new string[] { "Bob", "Mickle", "George", "Alex" };

            Console.WriteLine(students[1]);
        }
        //Двумерные массивы
        static void Main2()
        {
            string air = ""; //чтобы при выводе было красиво

            byte[] digits = new byte[5];

            digits[0] = 34;
            digits[4] = 255;

            Console.WriteLine(digits[3]);

            string[] students = new string[] { "Bob", "Mickle", "George", "Alex" };

            Console.WriteLine(students[1]);
            //знаю, что нельзя использовать повторы

            Console.WriteLine(air);

            Console.WriteLine(students[1]);

            short[,] nums = new short[5, 2];

            int[,] numbers =
            {
                {5, 7, 2 },
                {9, 200, 8 },
                {7, 0, 12 }
            };

            int len = students.Length;
            Console.WriteLine(len);

            Console.WriteLine(students[1]);

            string[] copyStudents = new string[len];
            students.CopyTo(copyStudents, 0);

            Console.WriteLine(copyStudents[1]);

            //ну тут явно не нужно переписывать код XD

            Console.WriteLine(air);

            numbers[2, 0] = 50;

            Console.WriteLine(numbers[1, 1]);
        }
        //Динамические массивы
        static void Main3()
        {
            List<short> digits = new List<short>() { 1, 0, 93, 75 };
            digits.Add(5);
            digits.AddRange(new short[] { 7, 8, 45 });
            digits.Insert(1, 178);
            digits.Remove(0);
            digits.RemoveAt(2);

            Console.WriteLine(digits[2]);
        }
    }
}
