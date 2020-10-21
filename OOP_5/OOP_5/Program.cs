using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = PathCheck("x");
            int i=0;
            int[] xs = new int[0];
            int[] ys = new int[0];
            Converter(ref xs, lines);
            lines = PathCheck("y");
            Converter(ref ys, lines);
            
            for (i = 0; i < xs.Length; i += 2)
            {
                if (xs[i] < 0)
                {
                    xs[i] = xs[i] * 2;
                }
            }
            //
            
            long[] zs =makeZ(xs,ys);
            Console.WriteLine("x:" + Liner(xs));
            Console.WriteLine("y:" + Liner(ys));
            Console.WriteLine("z:" + Liner(zs));
            Console.ReadKey();

        }
        static String filePath(String name)
        {
            Console.WriteLine("Введите путь к файлу с масивом "+name+":");
            return Console.ReadLine();
        }
        static string[] PathCheck(String name)
        {
            while (true)
            {
                String Path = filePath(name);
                if (File.Exists(Path))
                {
                    string[] lines;
                    lines = File.ReadAllLines(Path);
                    return lines;
                }
                else
                {
                    Console.WriteLine("Файл по такому пути не существует, желаете повторить попытку ввода?(Y/N)");
                    switch (Console.ReadKey().KeyChar)
                    {
                        case 'Y':
                            break;
                        default:
                            Console.WriteLine("Для продолжения работы необходимы оба файла!");
                            Console.ReadKey();
                            Environment.Exit(-1);
                            break;
                    }
                    continue;
                }
            }
        }
        static void Converter(ref int[] mas, string[] lines)
        {
            try
            {
                mas = new int[lines.Length];
                int i = 0;
                foreach (string line in lines)
                {
                    mas[i] = Convert.ToInt32(line);
                    i++;
                }
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Произошла ошибка при конвертации данных, проверьте информацию и повторите попытку позже!");
                Environment.Exit(1);
            }
        }
        static String Liner(int[] mas)
        {
            String rez = "";
            foreach (int temp in mas)
            {
                rez = rez + (Convert.ToString(temp) + " ");
            }
            return rez;
        }
        static String Liner(long[] mas)
        {
            String rez = "";
            foreach (int temp in mas)
            {
                rez = rez + (Convert.ToString(temp) + " ");
            }
            return rez;
        }
        static long[] makeZ(int[] a, int[] b)
        {
            
            int lenght = Math.Min(a.Length, b.Length);
            long[] zs = new long[lenght];
            for (int i = 0; i < lenght; i++)
            {
                zs[i] = (a[lenght - 1 - i] / b[i]);
            }
            Console.WriteLine(zs);
            return zs;
        }
    }
}
//C:\Temp\y.txt
