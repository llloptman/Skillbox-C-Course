using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfCards=0; //объявляем переменную для хранения суммы
            Console.WriteLine("Добро пожаловать! \n" +
                "Сколько у вас карт? \n" +
                "(введите число и нажмите enter)");// отображаем приветствие
            int pNumberOfCards = Convert.ToInt32(Console.ReadLine());//объявляем и преобразуем пользовательский ввод в число (ломается если ввести букву)
            for (int i = 0; i < pNumberOfCards; i++)//узнаем карты игрока по очереди и складываем сумму
            {
                Console.WriteLine("Какая у вас карта?\n" +
                    "введите 2-10 или J K Q T");
                string sCardValue = Console.ReadLine();
                #region made with IF
                //if (sCardValue.Equals("K") || sCardValue.Equals("J") || sCardValue.Equals("Q") || sCardValue.Equals("T"))
                //{
                //    sumOfCards += 10;
                //}

                //else if (sCardValue.Equals("2") || sCardValue.Equals("3") || sCardValue.Equals("4") || sCardValue.Equals("5")
                //    || sCardValue.Equals("6") || sCardValue.Equals("7") || sCardValue.Equals("8") || sCardValue.Equals("9") || sCardValue.Equals("10"))
                //{
                //    int iCardValue = Convert.ToInt32(sCardValue);
                //    sumOfCards += iCardValue;
                //}

                //else
                //{
                //    i--;
                //    Console.WriteLine("Вы ввели что-то не то !!!\n");

                //}
                #endregion
                #region made with Swich
                switch (sCardValue)
                {
                    
                    case "2": sumOfCards += 2;break;
                    case "3": sumOfCards += 3;break;
                    case "4": sumOfCards += 4;break;
                    case "5": sumOfCards += 5;break;
                    case "6": sumOfCards += 6;break;
                    case "7": sumOfCards += 7;break;
                    case "8": sumOfCards += 8;break;
                    case "9": sumOfCards += 9;break;
                    case "10": sumOfCards += 10;break;
                    case "K": 
                    case "J": 
                    case "Q": 
                    case "T": sumOfCards += 10;break;

           
                    default:
                        Console.WriteLine("Вы ввели несуществующую карту");
                        i--;
                        break;
                }
                #endregion
            }
            Console.WriteLine($"Ваша рука - {sumOfCards}");//выводим результат
            Console.ReadKey();//оставляем консоль открытой
        }
    }
}
