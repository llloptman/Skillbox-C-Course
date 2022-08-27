using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat_check
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            Menu(set);
        }
        public static void Menu(HashSet<string> set)
        {
            Console.WriteLine("Введите число");
            string number = Console.ReadLine();
            //HashSet<string> set2 = new HashSet<string>();
            //set2.Add(number);
            if (set.Contains(number))
            {
                Console.WriteLine($"число уже {number} вводилось");
            }
            else
            {
                Console.WriteLine($"Записываю число {number}");
                set.Add(number);
            }
            Menu(set);
        }
    }
}
