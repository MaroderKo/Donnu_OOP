﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donnu_OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть змінну типу інт:");
            string str = Console.ReadLine();
            try
            {
                int rez = Convert.ToInt32(str);
                Console.WriteLine(rez);
            }
            catch
            {
                Console.WriteLine("Помилка під час вводу змiнної Int!");
            }
            
            Console.WriteLine("Введіть змінну типу Double:");
            str = Console.ReadLine();
            try
            {
                double rez = Convert.ToDouble(str);
                Console.WriteLine(rez);
            }
            catch
            {
                Console.WriteLine("Помилка під час вводу змiнної Double!");
            }

            Console.WriteLine("Введіть змінну типу Long:");
            str = Console.ReadLine();
            try
            {
                long rez = Convert.ToInt64(str);
                Console.WriteLine(rez);
            }
            catch
            {
                Console.WriteLine("Помилка під час вводу змiнної Long!");
            }
            Console.ReadKey();


        }
    }
}
