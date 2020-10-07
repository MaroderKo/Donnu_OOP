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
            string[] lines = new string[0];
            int i=0;
            int[] xs = new int[0];
            int[] ys = new int[0];
            try
            {
                lines = File.ReadAllLines(@"C:\Temp\x.txt");
                xs = new int[lines.Length];
                i = 0;
                foreach (string line in lines)
                {
                    xs[i] = Convert.ToInt32(line);
                    i++;
                }
            }
            catch
            {
                Console.WriteLine("Произошла ошибка при считывании файла х, проверьте информацию и повторите попытку позже!");
                Environment.Exit(1);
            }
            try
            {
                lines = File.ReadAllLines(@"C:\Temp\y.txt");
                ys = new int[lines.Length];
                i = 0;
                foreach (string line in lines)
                {
                    ys[i] = Convert.ToInt32(line);
                    i++;
                }
            }
            catch 
            {
                Console.WriteLine("Произошла ошибка при считывании файла у, проверьте информацию и повторите попытку позже!");
                Environment.Exit(1);
            }
            //
            for (i = 0; i < xs.Length; i += 2)
            {
                if (xs[i] < 0)
                {
                    xs[i] = xs[i] * 2;
                }
            }
            //
            int lenght = Math.Min(xs.Length, ys.Length);
            int[] zs = new int[0];
            for (i = 0; i < lenght; i++)
            {
                zs.Append(xs[lenght - i] / ys[i]);
            }
            Console.WriteLine(zs);
        }
    }
}
