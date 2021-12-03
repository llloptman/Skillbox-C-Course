using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Разработайте программу по следующему алгоритму:

            //            Пользователь вводит максимальное целое число диапазона. 
            Console.WriteLine("Введите максимальное число из диапазона");
            int rangeMax = int.Parse(Console.ReadLine());
            int userGess;
            string userGessString;
            bool isInt;
            //На основе диапазона целых чисел(от 0 до «введено пользователем») программа генерирует случайное целое число из диапазона.
            Random random = new Random();
            int nuberToGess = random.Next(0, rangeMax + 1);
            //Пользователю предлагается ввести загаданное программой случайное число.Пользователь вводит свои предположения в консоли приложения.
            while (true)
            {
                Console.WriteLine("Введите число или нажмите enter, если устали играть");
                userGessString = Console.ReadLine();
                if (userGessString.Equals(""))
                {
                    Console.WriteLine($"{nuberToGess} - загаданное число");
                    break;
                }
                else if ((isInt = int.TryParse(userGessString, out userGess)))
                {
                    userGess = int.Parse(userGessString);
                    if (userGess > nuberToGess)
                    {
                        Console.WriteLine("Число больше загаданного");
                        continue;
                    }
                    if (userGess < nuberToGess)
                    {
                        Console.WriteLine("Число меньше загаданного");
                        continue;
                    }
                    if (userGess == nuberToGess)
                    {
                        Console.WriteLine("Вы угадали число");
                        break;
                    }
                }          
            }
            Console.ReadKey();
            //Если число меньше загаданного, программа сообщает об этом пользователю. 
            //Если больше, то тоже сообщает, что число больше загаданного.
            //Программа завершается, когда пользователь угадал число.
            //Если пользователь устал играть, то вместо ввода числа он вводит пустую строку и нажимает Enter. Тогда программа завершается, предварительно показывая, какое число было загадано.

        }
    }
}
