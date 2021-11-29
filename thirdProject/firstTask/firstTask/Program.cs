using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace firstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите число и нажмите enter, а я скажу четное оно или нет");
            int pNumber = Convert.ToInt32(ReadLine());
            if (pNumber%2 == 0)
            {
                WriteLine($"Ваше число {pNumber} - четное");
            }
            else
                WriteLine($"Ваше число {pNumber} - не четное");

            ReadKey();
        }

    }
}
