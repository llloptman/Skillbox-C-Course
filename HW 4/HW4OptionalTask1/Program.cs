using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4OptionalTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1.
            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
            // За год получены два массива – расходов и поступлений.
            // Определить прибыли по месяцам
            // Количество месяцев с положительной прибылью.
            // Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
            // если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            // Пример
            //       
            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000
            // 
            // Худшая прибыль в месяцах: 7, 4, 1, 5, 12
            // Месяцев с положительной прибылью: 10


            //задать 5 массива
            const int NumberOfMonths = 12;
            const int ColumnWideHeader = 25;
            const int ColumnWideTable = 23;
            string[] tableHeader = new string[] { "Месяц", "Доход, тыс.руб.", "Расход, тыс.руб.", "Прибыль, тыс.руб." };
            int[] months = new int[NumberOfMonths];
            int[] income;
            int[] expenses;
            int[] profit = new int[NumberOfMonths];


            //создать 2 метода инициализации
            //    1 - дефолт
            //    2 - с рандомными числами
            ShowTableHeader();// Показываем шапку таблицы
            DefaultTableInitialization();
            ShowTable();
            //ShowMonthsWithLessProfit();
            CountOfMonthsWithPositiveProfit();
            ShowMonthsWithLessProfit_V2();
            Console.ReadKey();


            void ShowTableHeader()
            {
                foreach (var item in tableHeader)
                {
                    Console.Write($"{item,ColumnWideHeader}");
                }
                Console.WriteLine();
            }
            void ShowTable()
            {
                for (int i = 0; i < NumberOfMonths; i++)
                {
                    if (profit[i] == 0)
                    {
                        Console.Write($"{months[i].ToString("### ###"),ColumnWideTable}" +
                        $"{income[i].ToString("### ###"),ColumnWideTable}" +
                        $"{expenses[i].ToString("### ###"),ColumnWideTable} " +
                        $"{profit[i],ColumnWideTable}\n");
                    }
                    else
                    {
                        Console.Write($"{months[i].ToString("### ###"),ColumnWideTable}" +
                       $"{income[i].ToString("### ###"),ColumnWideTable}" +
                       $"{expenses[i].ToString("### ###"),ColumnWideTable} " +
                       $"{profit[i].ToString("### ###"),ColumnWideTable}\n"); // Из-за маски возвращает пустую строку при 0
                    }


                }
                Console.WriteLine();
            }
            void DefaultTableInitialization()
            {
                for (int i = 0; i < NumberOfMonths; i++)
                {
                    months[i] += i + 1;
                }

                //ручное заполнение доходов и расходов
                income = new int[] { 100000, 120000, 80000, 70000, 100000, 200000, 130000, 150000, 190000, 110000, 150000, 100000 };
                expenses = new int[] { 80000, 90000, 70000, 70000, 80000, 120000, 140000, 65000, 90000, 70000, 120000, 80000 };

                for (int i = 0; i < NumberOfMonths; i++)
                {
                    profit[i] = income[i] - expenses[i];
                }
            }
            void ShowMonthsWithLessProfit()
            {
                int quantityOfBadMonths = 3;//склько худших месяцев искать
                int[] badMonthsIndexes = new int[NumberOfMonths];
                int[] sortedProfit = (int[])profit.Clone();
                int[] lowestProfit = new int[quantityOfBadMonths];

                int countOfMonth = 0;//счетчик для сравнения с количеством месяцев
                int lowestProfitCounter = 0;//счетчик количества худших месяцев при условии, что значения одинаково плохи

                Array.Sort(sortedProfit);

                for (int i = 0; i < sortedProfit.Length; i++) //найти 3 минимальных значения
                {
                    if (i != sortedProfit.Length)
                    {
                        for (int j = i + 1; j < sortedProfit.Length; j++)
                        {
                            if (sortedProfit[i] == sortedProfit[j] && countOfMonth < quantityOfBadMonths)
                            {
                                //Console.Write($"{sortedProfit[i]}, ");
                                lowestProfitCounter++;
                                i = j;
                                continue;
                            }
                            else
                            {
                                if (sortedProfit[i] < sortedProfit[j] && countOfMonth < quantityOfBadMonths)
                                {

                                    //Console.Write($"{sortedProfit[i]}, ");
                                    lowestProfit[countOfMonth] = sortedProfit[i];
                                    lowestProfitCounter++;
                                    countOfMonth++;
                                    break;
                                }

                            }

                        }
                    }
                    else
                    {
                        if (sortedProfit[i] == sortedProfit[i - 1] && countOfMonth <= quantityOfBadMonths)

                        {
                            Console.Write($"{sortedProfit[i]}, ");
                            lowestProfit[i] = sortedProfit[i];
                            continue;
                        }
                    }

                }
                countOfMonth = 0;
                //int j = 0;
                for (int j = 0; j < quantityOfBadMonths; j++)//найти индексы с минимальными значениями
                {
                    for (int i = 0; i < profit.Length; i++)
                    {
                        if (profit[i] == lowestProfit[j])
                        {
                            badMonthsIndexes[j] = i + 1;
                            countOfMonth++;
                        }
                    }

                }
                Console.Write("Худшая прибыль в месяцах: ");
                for (int i = 0; i < countOfMonth; i++)
                {
                    if (i == countOfMonth - 1)
                    {
                        Console.Write($"{badMonthsIndexes[i]}. ");
                    }
                    else Console.Write($"{badMonthsIndexes[i]}, ");
                }
                Console.WriteLine();
            }
            void CountOfMonthsWithPositiveProfit()
            {
                int count = 0;
                foreach (var item in profit)
                {
                    if (item > 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Месяцев с положительной прибылью: {count}");
            }
            void ShowMonthsWithLessProfit_V2()
            {
               // profit = new int[]{ 2,2,2,2,2,2,2,2,2,2,2,2};
               //profit = new int[]{ 1,2,-1,0,1,2,-1,0,-1,0,-2,0};
                int countOfMonths = 0;
                Array.Sort(profit, months);
                for (int i = 0; i < profit.Length - 1; i++)
                {
                    if (i != profit.Length)
                    {
                        if (countOfMonths < 3)
                        {
                            Console.Write($"Profit = {profit[i]}, month {months[i]} ->");
                        }
                        if (profit[i] < profit[i + 1])
                        {
                            countOfMonths++;
                        }
                    }
                }
                if (profit[profit.Length-2] == profit[profit.Length-1] && countOfMonths <= 3)
                        {
                            Console.Write($"Profit = {profit[profit.Length-1]}, month {months[profit.Length-1]} ->");
                        }
                   
                
                Console.WriteLine();
            }
        }

    }
}