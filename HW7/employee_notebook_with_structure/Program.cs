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
                repository.ShowNotesInConsole();
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
