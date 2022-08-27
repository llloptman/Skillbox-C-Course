using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_with_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> hundredNumers = new List<int>(100);
            Fill100(hundredNumers);
            ShowList(hundredNumers);
            DeleteNubersInRange(hundredNumers);
            ShowList(hundredNumers);
            
        }
        public static void Fill100(List<int> list)
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(random.Next(0,100));
            }
        }
        public static void ShowList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void DeleteNubersInRange (List<int> list, int min, int max)
        {
            foreach (var item in list.Reverse<int>())
            {

                if (item >= min && item <= max)
                {
                    list.Remove(item);
                }
            }
        }
        public static void DeleteNubersInRange (List<int> list)
        {
            foreach (var item in list.Reverse<int>())
            {

                if (item >= 25 && item <= 50)
                {
                    list.Remove(item);
                }
            }
           
        }

    }
}
