using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Просматривая сайты по поиску работы, у вас вызывает интерес следующая вакансия:

            // Требуемый опыт работы: без опыта
            // Частичная занятость, удалённая работа
            //
            // Описание 
            //
            // Стартап «Micarosppoftle» занимающийся разработкой
            // многопользовательских игр ищет разработчиков в свою команду.
            // Компания готова рассмотреть C#-программистов не имеющих опыта в разработке, 
            // но желающих развиваться в сфере разработки игр на платформе .NET.
            //
            // Должность Интерн C#/
            //
            // Основные требования:
            // C#, операторы ввода и вывода данных, управляющие конструкции 
            // 
            // Конкурентным преимуществом будет знание процедурного программирования.
            //
            // Не технические требования: 
            // английский на уровне понимания документации и справочных материалов
            //
            // В качестве тестового задания предлагается решить следующую задачу.
            //
            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером


            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!
            int userTry;
            int userTryMin = 1;
            int userTryMax = 4;
            int gameNumberMin = 12;
            int gameNumberMax = 120;
            int numberOfPlayers = 2;
            Random random = new Random();
            
            //Приветствие
            string greatingsText = "Приветствую вас в игре!\n" +
                "                               Это игра для двоих, \n" +
                "Я загадаю число, а вы по очереди будете отнимать от него числа в диапазоне {0}-{1}\n " +
                "                                удачи вам!";

            Console.WriteLine("Хотите настроить игру? (yes or no)");
            string settings = Console.ReadLine();
            if (settings.ToLower().Contains("yes"))
            {
                Console.WriteLine("Задайте количество игроков 1 или 2");
                numberOfPlayers = int.Parse(Console.ReadLine());

                Console.WriteLine("Задайте диапазон значений для вычитания");
                Console.WriteLine("Введите минимальное число");
                userTryMin = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите максимальное число");
                userTryMax = int.Parse(Console.ReadLine());

                Console.WriteLine("Задайте диапазон в котором я могу загадать число");
                Console.WriteLine("Введите минимальное число");
                gameNumberMin = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите максимальное число");
                gameNumberMax = int.Parse(Console.ReadLine());
            }

            int gameNumber = random.Next(gameNumberMin, gameNumberMax + 1);//загадываем число

            if (numberOfPlayers == 1)
            {
                foreverAlone();
            }
            else
            {
                gameFor2Players();
            }



            string centeredString(string s, int width)
            {
                if (s.Length >= width)
                {
                    return s;
                }

                int leftPadding = (width - s.Length) / 2;
                int rightPadding = width - s.Length - leftPadding;

                return new string(' ', leftPadding) + s + new string(' ', rightPadding);
            }
            void gameFor2Players()
            {
                //При старте, игрокам предлагается ввести свои никнеймы.
                Console.WriteLine(centeredString(greatingsText, 500), userTryMin, userTryMax);
                Console.WriteLine("Игрок 1 введите ваше имя и нажмите Enter");
                string p1Name = Console.ReadLine();
                Console.WriteLine("Игрок 2 введите ваше имя и нажмите Enter");
                string p2Name = Console.ReadLine();

                while (gameNumber > 0)
                {


                    if (gameNumber != 0)
                    {
                        Console.WriteLine($"Загаданное число: {gameNumber}");
                        Console.WriteLine($"Ход : {p1Name}");
                        userTry = int.Parse(Console.ReadLine());

                        if (userTry >= userTryMin && userTry <= userTryMax)
                        {
                            gameNumber -= userTry;
                            if (gameNumber == 0)
                            {
                                Console.WriteLine($"Игрок : {p1Name} - Победил");
                            }
                        }
                        else
                        {
                            while (!(userTry >= userTryMin && userTry <= userTryMax))
                            {
                                Console.WriteLine("Введи число из диапозона {0}-{1}", userTryMin, userTryMax);
                                userTry = int.Parse(Console.ReadLine());
                            }
                            gameNumber -= userTry;
                            if (gameNumber == 0)
                            {
                                Console.WriteLine($"Игрок : {p1Name} - Победил");
                            }
                        }
                    }


                    if (gameNumber != 0)
                    {
                        Console.WriteLine($"Загаданное число: {gameNumber}");
                        Console.WriteLine($"Ход : {p2Name}");
                        userTry = int.Parse(Console.ReadLine());

                        if (userTry >= userTryMin && userTry <= userTryMax)
                        {
                            gameNumber -= userTry;
                            if (gameNumber == 0)
                            {
                                Console.WriteLine($"Игрок : {p2Name} - Победил");
                            }
                        }
                        else
                        {
                            while (!(userTry >= userTryMin && userTry <= userTryMax))
                            {
                                Console.WriteLine("Введи число из диапозона {0}-{1}", userTryMin, userTryMax);
                                userTry = int.Parse(Console.ReadLine());
                            }
                            gameNumber -= userTry;
                            if (gameNumber == 0)
                            {
                                Console.WriteLine($"Игрок : {p2Name} - Победил");
                            }
                        }

                    }
                }
                Console.ReadKey();
            }
            void foreverAlone()
            {
                Console.WriteLine(centeredString(greatingsText, 500), userTryMin, userTryMax);
                Console.WriteLine("Как тебя зовут одинокий волк? нажмите Enter");
                string p1Name = Console.ReadLine();
                string p2Name = "I'm your Dady!";

                while (gameNumber > 0)
                {
                    if (gameNumber != 0)
                    {
                        Console.WriteLine($"Загаданное число: {gameNumber}");
                        Console.WriteLine($"Ход : {p1Name}");
                        userTry = int.Parse(Console.ReadLine());

                        if (userTry >= userTryMin && userTry <= userTryMax)
                        {
                            gameNumber -= userTry;
                            if (gameNumber == 0)
                            {
                                Console.WriteLine($"Игрок : {p1Name} - Победил");
                            }
                        }
                        else
                        {
                            while (!(userTry >= userTryMin && userTry <= userTryMax))
                            {
                                Console.WriteLine("Введи число из диапозона {0}-{1}", userTryMin, userTryMax);
                                userTry = int.Parse(Console.ReadLine());
                            }
                            gameNumber -= userTry;
                            if (gameNumber == 0)
                            {
                                Console.WriteLine($"Игрок : {p1Name} - Победил");
                            }
                        }

                    }
                    if (gameNumber != 0)
                    {
                        Console.WriteLine($"Загаданное число: {gameNumber}");
                        Console.WriteLine($"Ход : {p2Name}");
                        if (gameNumber >= userTryMin && gameNumber <= userTryMax)
                        {
                            userTry = gameNumber;
                            gameNumber -= userTry;
                            Console.WriteLine(userTry);
                        }
                        else
                        {
                            userTry = random.Next(userTryMin, userTryMax + 1);
                            gameNumber -= userTry;
                            Console.WriteLine(userTry);
                        }
                        if (gameNumber == 0)
                        {
                            Console.WriteLine($"Игрок : {p2Name} - Победил");
                        }
                    }
                }
                Console.ReadKey();
            }

        }
    }
}
