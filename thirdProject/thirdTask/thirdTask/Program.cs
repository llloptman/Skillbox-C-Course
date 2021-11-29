using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isSimple = true;
            Console.WriteLine("Введите целое число, а я скажу простое оно или нет");
            int pNumber = Convert.ToInt32(Console.ReadLine());
            int startDelimetr = 2;
            while (startDelimetr < pNumber-1)
            {
                if (pNumber%startDelimetr == 0)
                {
                    isSimple = false;
                }
                startDelimetr++;
                
            }
            if (isSimple == true)
            {
                Console.WriteLine($"Ваше число {pNumber} - простое");
            }
            else
            {
                Console.WriteLine($"Ваше число {pNumber} - сложное");
            }
                Console.ReadKey();
        }
    }
}
