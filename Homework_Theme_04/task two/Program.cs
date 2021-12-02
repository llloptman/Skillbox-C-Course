using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Найдите наименьший элемент в последовательности, которую вводит пользователь.Последовательность нужно сохранить в массив.Детальный алгоритм программы:

            //            Пользователь вводит длину последовательности. 
            Console.WriteLine("Введите длину последовательности");
            int subsequenceLength = int.Parse(Console.ReadLine());
            int[] subsequence = new int[subsequenceLength];
            int min = int.MaxValue;
            //Затем пользователь последовательно вводит целые числа(как положительные, так и отрицательные). Числа разделяются клавишей Enter.
            //Каждое введённое число помещается в соответствующий элемент массива.
            for (int i = 0; i < subsequenceLength; i++)
            {
                Console.WriteLine("Введите число");
                subsequence[i] = int.Parse(Console.ReadLine());  
            }

            //После окончания ввода данных отдельный цикл проходит по последовательности и находит минимальное число.Для этого он сравнивает каждое число в итерации с предыдущим найденным минимальным числом.
            for (int i = 0; i < subsequenceLength; i++)
            {
                
                if (subsequence[i] < min)
                {
                    min = subsequence[i];
                }
            }
            Console.WriteLine($"{min} - минимальное число в последовательности");
            Console.ReadKey();
        }
    }
}
