using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_notebook_with_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository rep1 = new Repository();
            Menu(rep1);



        }
        static void Menu(Repository repository)
        {
            Console.WriteLine("\nЕсли хотите просмотреть записи - введите 1\n" +
                "Если хотите сделать запись - введите 2\n" +
                "Если хотите выбрать другой файл - введите 3");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Если хотите посмотреть все записи - введите 1");
                Console.WriteLine("Если хотите посмотреть запись по id - введите 2");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    repository.ShowNotesInConsole();
                    Menu(repository);
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Введите id записи");
                    string id = Console.ReadLine();
                    repository.GetWorkerById(id);
                    Menu(repository);
                }
            }
            if (choice == "2")
                repository.AddWorker();
            if (choice == "3")
            {
                Console.WriteLine("Введите название нового файла");
                repository.SetFileName(Console.ReadLine());
                Menu(repository);
            }

            else Menu(repository);
        }
    }
}
