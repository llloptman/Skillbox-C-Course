using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> telephoneBook = new Dictionary<string, string>();
            Menu(telephoneBook);

        }
        public static void  CreateNote(Dictionary<string, string> telephoneBook, string phone, string name)
        {
            telephoneBook.Add(phone, name);
        }
        public static bool NullStringCheck (string phone,string name)
        {
            bool isNull = false;
            if (phone.Equals("") || name.Equals(""))
            {
                isNull = true;
            }
            return isNull;
        }
        public static void FindPersonByPhone(Dictionary<string,string> telephoneBook, string phone)
        {
            string value = "";
            if (telephoneBook.TryGetValue(phone, out value))
            {
                Console.WriteLine($"{value}");
            }
            else
            {
                Console.WriteLine("Запись не найдена");
            }
        }
        public static void Menu(Dictionary<string,string> telehoneBook)
        {
            Console.WriteLine("Введите номер");
            string phone = Console.ReadLine();
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            if (!NullStringCheck(phone,name))
            {
                CreateNote(telehoneBook, phone, name);
                Menu(telehoneBook);
            }
            else
            {
                Console.WriteLine("Введите номер, чтоб найти кому он пренадлежит");
                phone = Console.ReadLine();
                FindPersonByPhone(telehoneBook,phone);
            }
            Console.ReadKey();

        }
    }
}
