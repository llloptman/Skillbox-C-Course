using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Book
{
    public class Person
    {
        string name;
        string street;
        string house;
        string flat;
        string hPhone;
        string mPhone;

        public Person(string name, string street, string house, string flat, string hPhone, string mPhone)
        {
            this.name = name;
            this.street = street;
            this.house = house;
            this.flat = flat;
            this.hPhone = hPhone;
            this.mPhone = mPhone;
        }
        public Person()
        {
            Console.WriteLine("Введите имя");
            this.name = Console.ReadLine();
            Console.WriteLine("Введите улицу");
            this.street = Console.ReadLine();
            Console.WriteLine("Введите номер дома");
            this.house = Console.ReadLine();
            Console.WriteLine("Введите номер квартиры");
            this.flat = Console.ReadLine();
            Console.WriteLine("Введите домашний телефон");
            this.hPhone = Console.ReadLine();
            Console.WriteLine("Введите мобильный телефон");
            this.mPhone = Console.ReadLine();
        }

        public string Name { get => name; set => name = value; }
        public string Street { get => street; set => street = value; }
        public string House { get => house; set => house = value; }
        public string Flat { get => flat; set => flat = value; }
        public string HPhone { get => hPhone; set => hPhone = value; }
        public string MPhone { get => mPhone; set => mPhone = value; }
    }

}
