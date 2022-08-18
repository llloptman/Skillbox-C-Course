using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu("employees notebook.txt");
            Console.ReadKey();
        }

        static void WriteToFile(string fileName)
        {
            int id = GetId(fileName);

                using (StreamWriter sw = File.AppendText(fileName))
                {

                    string note = string.Empty;
                    note += $"{id,3}#";
                    string now = DateTime.Now.ToString();
                    note += $"{now,20}#";
                    Console.WriteLine("\n Введите ФИО сотрудника");
                    note += $"{Console.ReadLine(),15}#";
                    Console.WriteLine("\n Введите возраст сотрудника");
                    note += $"{Console.ReadLine(),5}#";
                    Console.WriteLine("\n Введите рост сотрудника");
                    note += $"{Console.ReadLine(),5}#";
                    Console.WriteLine("\n Введите дату рождения сотрудника");
                    note += $"{Console.ReadLine(),20}#";
                    Console.WriteLine("\n Введите место рождения сотрудника");
                    note += $"{Console.ReadLine(),15}";
                    sw.Write($"{note}\n");
                    sw.Close();
                    Menu(fileName);
                }
            
        }

        static void ReadFromFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
                {

                }

            }
            MakeHeader();
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('#');
                    Console.Write($"{data[0],3}{data[1],20}{data[2],20}{data[3],5}{data[4],5}{data[5],20}{data[6],15}\n");
                }
                sr.Close();
                Menu(fileName);
            }
        }

        static void MakeHeader()
        {
            Console.Write($"{"id",3}{"date",20}{"FIO ",20}{"Age ",5}{"Hieght ", 5}{"birth day ", 20}{"Birth Place ",15}\n");
        }

        static void Menu(string fileName)
        {
            Console.WriteLine("Если хотите просмотреть записи - введите 1\n" +
                "Если хотите сделать запись - введите 2");
            string choice = Console.ReadLine();

            if (choice == "1")
                ReadFromFile(fileName);
            if (choice == "2")
                WriteToFile(fileName);
            else Menu(fileName);
        }
        public static int GetId (string fileName){

            int id = 0;
                if (!File.Exists(fileName))
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
                {

                }
                return id;
            }
             using (StreamReader sr = new StreamReader(fileName))
                {
                 string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('#');
                     id = Convert.ToInt32(data[0].Trim());

                    Console.Write($"{data[0],3}{data[1],20}{data[2],20}{data[3],5}{data[4],5}{data[5],20}{data[6],15}\n");
                }
                sr.Close();
             }
             return id + 1;
        }
    }
}
