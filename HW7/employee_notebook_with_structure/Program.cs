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
                Console.WriteLine("Если хотите посмотреть записи созданные в определенное время - введите 3");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    repository.ShowNotesInConsole(repository.GetAllWorkers());
                    Menu(repository);
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Введите id записи");
                    string id = Console.ReadLine();
                    
                    if (repository.GetWorkerById(id).Id != -1)
                    {
                    repository.ShowWorker(repository.GetWorkerById(id));

                    Console.WriteLine("Удалить? (Y/N)");
                    string delete = Console.ReadLine();
                    if (delete.ToLower().Equals("y"))
                    {
                        repository.DeleteById(id);
                        repository.ShowNotesInConsole(repository.GetAllWorkers());
                        Menu(repository);
                    }
                    }
                    else Console.WriteLine("Запись не найдена");

                    Menu(repository);
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Введите дату с которой начать поиск в формате дд мм гггг");
                    DateTime from =Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Введите дату до которой начать поиск в формате дд мм гггг");
                    DateTime to =Convert.ToDateTime(Console.ReadLine());
                    repository.ShowNotesInConsole(repository.GetWorkersInRange(from, to));
                    Menu(repository);
                }
            }
            if (choice == "2")
                repository.AddWorker(new Worker(repository.GenerateID()));
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
