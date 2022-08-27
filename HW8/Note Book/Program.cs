using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.Linq;


namespace Note_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{

            //    Person person = new Person($"Имя {i}", $"улица {i}", $"дом {i}", $"квартира {i}", $"домашний телефон {i}", $"мобильный {i}");
            //    Console.WriteLine($"{person.Name} {person.Street} {person.House} {person.Flat} {person.HPhone} {person.MPhone}");
            //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            //    Stream stream = new FileStream("person.xml",FileMode.Append, FileAccess.Write);
            //    xmlSerializer.Serialize(stream, person);
            //    stream.Close();
            //}
            CreatePerson();
            Console.ReadKey();
        }   

        public static void CreatePerson()
        {
            Person person = new Person();
            Console.WriteLine($"{person.Name} {person.Street} {person.House} {person.Flat} {person.HPhone} {person.MPhone}");
            XElement person1 = new XElement("Person");
            XElement adress = new XElement("Adress");
            XElement street = new XElement("Street",person.Street);
            XElement house = new XElement("HouseNumber",person.House);
            XElement flat = new XElement("FlatNumber", person.Flat);
            XElement phones = new XElement("Phones");
            XElement fPhones = new XElement("FlatPhones", person.HPhone);
            XElement mPhones = new XElement("MobilePhones", person.MPhone);

            XAttribute name = new XAttribute("name", person.Name);

            phones.Add(mPhones);
            phones.Add(fPhones);

            adress.Add(street);
            adress.Add(house);
            adress.Add(flat);

            person1.Add(name);
            person1.Add(adress);
            person1.Add(phones);

            person1.Save("person.xml");

        }
        public static void ClearFile()
        {
            Stream stream = new FileStream("person.xml", FileMode.Truncate);
        }
    }
}
