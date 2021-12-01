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
            string stop = "stop";
            int gameNumber;
            bool soloGame = false;
            bool pcTurn = false;
            Random random = new Random();
            
           
            string greatingsText = "                             Приветствую вас в игре!\n" +
                "                               Это игра для {0}, \n" +
                "Я загадаю число, а вы по очереди будете отнимать от него числа в диапазоне {1}-{2}\n " +
                "                                удачи вам!";


            //Приветствие
            
            Settings();
            string[] playerNames = new string[numberOfPlayers + 1];
            Console.WriteLine(greatingsText, numberOfPlayers, userTryMin, userTryMax);
            InsertPlayerNames();



            for (; ; )
                
            {
               gameNumber = random.Next(gameNumberMin, gameNumberMax + 1);//загадываем число

               
                    GameFor2PlusPlayers();
                
                Console.WriteLine("Реванш?\n" +
                    "для отмены напишите stop");

                if (Console.ReadLine().ToLower().Equals(stop))
                {
                    break;
                }
            }



           
            void GameFor2PlusPlayers()
            {

                if (soloGame == true)
                {
                    numberOfPlayers = 2;
                }
                int pId = 0;
                

                while (gameNumber > 0)
                {


                    if (gameNumber != 0)
                    {
                        Console.WriteLine($"Загаданное число: {gameNumber}");
                        Console.WriteLine($"Ход : {playerNames[pId]}");
                        if (gameNumber >= userTryMin && gameNumber <= userTryMax && pcTurn == true)
                        {
                            userTry = gameNumber;
                            gameNumber -= userTry;
                            Console.WriteLine(userTry);
                        }
                        else if (pcTurn == true)
                        {
                            userTry = random.Next(userTryMin, userTryMax + 1);
                            gameNumber -= userTry;
                            Console.WriteLine(userTry);
                            pcTurn = false;
                            pId = 0;
                            continue;
                        }



                        userTry = int.Parse(Console.ReadLine());

                        if (userTry >= userTryMin && userTry <= userTryMax)
                        {
                            gameNumber -= userTry;
                            if (gameNumber == 0)
                            {
                                Console.WriteLine($"Игрок : {playerNames[pId]} - Победил");
                                break;
                            }
                        }
                        else
                        {

                            Console.WriteLine($"введите число в интервале {userTryMin} - {userTryMax}");
                            continue;
                        }
                           
                            
                    }
                    if (pId < numberOfPlayers -1 && pcTurn == false)
                    {
                        pId++;
                        if (soloGame == true && pcTurn == false)
                        {
                            pcTurn = true;
                        }
                        
                    }
                    else pId = 0;
                }
            }
            void InsertPlayerNames()
            {
                if (numberOfPlayers == 1)
                {
                    playerNames[1] = "I'm your Dady!";
                    soloGame = true;
                }
                for (int i = 0; i < numberOfPlayers; i++)
                {
                    Console.WriteLine($"Игрок {i + 1} введите ваше имя и нажмите Enter");
                    playerNames[i] = Console.ReadLine();
                }
            }
                        
            void Settings()
            {
                Console.WriteLine("Хотите настроить игру? (yes or no)");
                string settings = Console.ReadLine();
                if (settings.ToLower().Contains("yes"))
                {
                    Console.WriteLine("Задайте количество игроков 1 или больше");
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
            }
        }

        
    }
}
