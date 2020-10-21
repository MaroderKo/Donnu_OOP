using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.ObjectModel;

namespace OOP_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Points p = new Points();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите номер функции которую вы-бы хотели протестить:");
                Console.WriteLine("a) вводити координати точки з клавiатури(файлу);\nb) виводити координати точки на екран(файл);\nc) знаходити вiдстанi мiж двома точками;\nd) знаходити найменшу / найбiльшу вiдстань вiд заданої точки, до множини точок(заданих масивом).\nе)Вийти с програмы ");
                char ans = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (ans) 
                {
                    case 'a':
                        Input(ref p);
                        break;
                    case 'b':
                        p.Print();
                        break;
                    case 'c':
                        p.LineSize();
                        break;
                    case 'd':
                        p.Find_long();
                        break;
                    case 'e':
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Введите коректную букву ответа!");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
                
            }
        }
        public static void Input(ref Points p)
        {
            Console.WriteLine("a)Ввести из файла\nb)Ввести вручную");
            char ans = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (ans)
            {
                case 'a':
                    XmlSerializer formatter = new XmlSerializer(typeof(Points));
                    using (FileStream fs = new FileStream("points.xml", FileMode.OpenOrCreate))
                    {
                        p = (Points)formatter.Deserialize(fs);

                        Console.WriteLine("Объект загружен");
                    }
                    Console.ReadKey();
                    break;
                case 'b':
                    try
                    {
                        Console.WriteLine("Введите координату Х первой точки:");
                        p.setX1(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Введите координату У первой точки:");
                        p.setY1(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Введите координату X второй точки:");
                        p.setX2(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Введите координату У второй точки:");
                        p.setY2(Convert.ToInt32(Console.ReadLine()));
                        break;
                    }
                    catch (InvalidCastException e)
                    {
                        Console.WriteLine("При вводе данных произошла ошибка "+e.Message+", данные небыли сохранены!\nЖелаете повторить ввод координат?(y/n)");
                        if (Console.ReadKey().KeyChar.Equals('y'))
                        {
                            Input(ref p);
                        }
                    }
                    break;
                
            }
            if (ans == 'a')
            {
                
            }
            else if (ans == 'b')
            {
                try
                {
                    Console.WriteLine("Введите координату Х первой точки:");
                    p.setX1( Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Введите координату У первой точки:");
                    p.setY1( Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Введите координату X второй точки:");
                    p.setX2( Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Введите координату У второй точки:");
                    p.setY2( Convert.ToInt32(Console.ReadLine()));
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("При вводе данных произошла ошибка"+e.Message+", данные небыли сохранены!\nЖелаете повторить ввод координат?(y/n)");
                    if (Console.ReadKey().KeyChar.Equals('y'))
                    {
                        Input(ref p);
                    }
                }

            }


        }
    }

    [Serializable]
    public class Points
    {
        
        
        double x1=0;
        double x2=0;
        double y1 = 0;
        double y2 = 0;
        public Points()
        {
            
        }
        public void setX1(int x)
        {
            x1 = x;
        }
        public void setY1(int x)
        {
            y1 = x;
        }
        public void setX2(int x)
        {
            x2 = x;
        }
        public void setY2(int x)
        {
            y2 = x;
        }
        public void Print()
        {
            Console.WriteLine($"x1={x1}\ny1={y1}\nx2=={x2}\ny2={y2}");
            Console.WriteLine("Сохранить точки в файл? (y/n)");
            if (Console.ReadKey().KeyChar.Equals('y'))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Points));
                using (FileStream fs = new FileStream("points.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, this);

                    Console.WriteLine("Объект сохранён!");
                }
                Console.ReadKey();
            }
            
        }

        

        public void LineSize()
        {
            Console.WriteLine($"Расстояние между точками:{Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2))}");
            Console.ReadKey();
        }
        private double longer(double x1, double y1, double x2,  double y2)
        {
            return (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
        }

        public void Find_long()
        {
            Collection < Collection<float> > Collection = new Collection<Collection<float>>();
            while (true)
            {
                Console.Clear();
                String ans;
                Console.WriteLine("Введите координаты точек в масив:\nP.S. Для выхода введите !");
                
                Console.WriteLine("Введите координату Х точки:");
                ans = Console.ReadLine();
                if (ans == "!")
                    break;
                float x = Convert.ToInt32(ans);
                Console.WriteLine("Введите координату У точки:");
                ans = Console.ReadLine();
                if (ans == "!")
                    break;
                float y = Convert.ToInt32(ans);
                Collection<float> temp = new Collection<float>();
                temp.Add(x);
                temp.Add(y);
                Collection.Add(temp);
            }
            if (Collection.Count == 0)
            {
                Console.WriteLine("Масив пуст!");
                Console.ReadKey();
            }
            else
            {
                double min = 100000000;
                double max = 0;
                foreach (Collection<float> temp in Collection)
                {
                    double rez = longer(x1, y1, temp[0], temp[1]);
                    if (rez > max)
                        max = rez;
                    else if (rez < min)
                        min = rez;
                    rez = longer(x2, y2, temp[0], temp[1]);
                    if (rez > max)
                        max = rez;
                    else if (rez < min)
                        min = rez;
                }
                Console.WriteLine($"Максимальное расстояние:{max}");
                Console.WriteLine($"Минимальное расстояние:{min}");
                Console.ReadKey();
            }
        }
    }
}
