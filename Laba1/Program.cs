using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;


namespace Laba1
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер задание, которое хотите выполнить?");
                string choose = "";
                choose = Console.ReadLine();
                if (choose == "1")
                {
                    Console.Clear();
                    First();
                }
                else if (choose == "2")
                {
                    Console.Clear();
                    Second();
                }
                else if (choose == "3")
                {
                    Console.Clear();
                    Third();
                }
                else
                {
                    Console.WriteLine("Вы ввели неверный номер");
                }
            
            Console.ReadKey();
        }



        static void First()
        {
            Console.Write("Введите количество элементов массива: ");
            int count = int.Parse(Console.ReadLine());

            List<int> list = new List<int>(count);
            List<int> evenlist = new List<int>() ;
            List<int> oddlist = new List<int>();

            for (int i = 1; i < count + 1; i++)
            {
                Console.Write($"Введите элемент списка под индексом {i}: ");
                list.Add(int.Parse(Console.ReadLine()));

            }
            Console.WriteLine();

            Console.Write("Список четных элементов: ");
            for (int k = 1; k < count + 1; k++)
            {
                if (list[k - 1] % 2 == 0)
                {
                    Console.Write(list[k - 1] + " ");
                }
            }
            Console.WriteLine();

           Console.Write("Список нечетных элементов: ");
            for (int k = 1; k < count + 1; k++)
            {
                if (list[k - 1] % 2 != 0)
                {
                    Console.Write(list[k - 1] + " ");
                }
            }
            Console.WriteLine();

            foreach (var number in list) 
            {
                if (number % 2 == 0)
                {
                    evenlist.Add(number);
                }
                else 
                {
                    oddlist.Add(number);
                }
            }

            Console.Write("\nИзначальный список: ");
            foreach (int j in list)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();

            Console.Write("Отсортированный список: ");
            evenlist.AddRange(oddlist);
            Console.Write(string.Join(" ", evenlist));

        }


        static void Second()
        {
                    Dictionary<string, double> arr = new Dictionary<string, double>()
                      {
                             { "item1", 2.45 },
                             { "item2", 46},
                             { "item3", 35.50 },
                             { "item4", 21},
                             { "item5", 28.90}
                      };

                    Console.WriteLine("Изначальный словарь: ");
                    foreach (KeyValuePair<string, double> sort in arr)
                    {
                        Console.WriteLine($"{sort.Key} {sort.Value}");
                    }

                    Console.WriteLine();

                    Console.WriteLine("Максимальные элементы словаря: ");
                    for (int i = 0; i < 3; i++)
                    {
                        double result = arr.Values.Max();
                        string k = arr.Where(x => x.Value == result).FirstOrDefault().Key;
                        Console.WriteLine(k + " " + result);
                        arr.Remove(k);
                    }
                    Console.WriteLine();
                
        }

        static void Third()
        {
            Console.Write("Введите количество элементов массива: ");
            int count = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(count);
            List<int> evenlist = new List<int>();

            for (int i = 1; i < count + 1; i++)
            {
                Console.Write($"Введите элемент списка под индексом {i}: ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine();

            Console.Write("Список четных отрицательных элементов: ");
            for (int k = 1; k < count + 1; k++)
            {
                if (list[k - 1] % 2 == 0 && list[k - 1] < 0)
                {
                    Console.Write(list[k - 1] + " ");
                }
            }
            Console.WriteLine();

            foreach (var number in list) 
            {
                if (number % 2 == 0 && number < 0) 
                {
                    evenlist.Add(number);
                }
            }

            Console.Write("Отсортированный список: ");
            var sort = evenlist.OrderBy(i => i);
            foreach (int k in sort) 
            {
                Console.Write(k+" ");
            }
            Console.WriteLine();

            Console.Write("Наоборот отсортированный список: ");
            var ordered1 = from m in evenlist
                          orderby m descending
                          select m;
            //var ordered1 = evenlist.OrderByDescending(m => m);
            foreach (int m in ordered1)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();
        }
    }
}
