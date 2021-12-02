using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_One
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Выведите на экран матрицу заданного размера и заполните её случайными числами.Детальный алгоритм работы приложения:

            //Сначала пользователю предлагается ввести количество строк в будущей матрице.
            Console.WriteLine("введите количество строк в будущей матрице");
            int rowNum = int.Parse(Console.ReadLine());
            //Затем — ввести количество столбцов в будущей матрице.
            Console.WriteLine("введите количество столбцов в будущей матрице");
            int colNum = int.Parse(Console.ReadLine());
            //После того, как данные будут получены, нужно создать в памяти матрицу заданного размера.
            int[,] matrix = new int[rowNum, colNum];
            //Используя Random, заполнить матрицу случайными целыми числами.
            Random random = new Random();
            int eSum = 0;
            for (int i = 0; i<rowNum; i++)
            {
                for (int j = 0; j < colNum; j++)
                {
                    matrix[i, j] = random.Next(1, 11);
                    eSum += matrix[i, j];
                }
                
            }
            //Вывести полученную матрицу на экран.
            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < colNum; j++)
                {
                    Console.Write($"{matrix[i,j]} ",3);
                }
                Console.WriteLine();

            }

            //Вывести суммы всех элементов этой матрицы на экран отдельной строкой.
            Console.WriteLine($"{eSum} - сумма всех элементов");
            Console.ReadKey();
        }
    }
}
