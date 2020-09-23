using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donnu_OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean Flag = false;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            while (!Flag)
            {
                Console.WriteLine("Введіть змінну типу інт:");
                string str = Console.ReadLine();
                try
                {
                    int rez = Convert.ToInt32(str);
                    Console.WriteLine(rez);
                    Flag = true;
                }
                catch
                {
                    Console.WriteLine("Помилка під час вводу змiнної Int!");
                }
            }
            Flag = false;
            while (!Flag)
            {
                Console.WriteLine("Введіть змінну типу Double:");
                string str = Console.ReadLine();
                try
                {
                    double rez = Convert.ToDouble(str);
                    Console.WriteLine(rez);
                    Flag = true;
                }
                catch
                {
                    Console.WriteLine("Помилка під час вводу змiнної Double!");
                }
            }
            Flag = false;
            while (!Flag)
            {
                Console.WriteLine("Введіть змінну типу Long:");
                string str = Console.ReadLine();
                try
                {
                    long rez = Convert.ToInt64(str);
                    Console.WriteLine(rez);
                }
                catch
                {
                    Console.WriteLine("Помилка під час вводу змiнної Long!");
                }
            }



        }
    }
}
