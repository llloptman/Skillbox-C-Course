using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_notebook_with_structure
{
    class Repository
    {
        List<Worker> workers;
        string fileName;

        public string FileName { get => fileName; set => fileName = value; }

        public Repository()
        {
            workers = new List<Worker>();
            fileName = "default note.txt";
        }
        public void SetFileName(string fileName) {
            this.fileName = fileName+".txt";
        }
        public void AddWorker(Worker worker)
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {

                string note = string.Empty;
                note += $"{worker.Id,3}#";
                note += $"{worker.DateOfNote,20}#";
                note += $"{worker.FIO,15}#";
                note += $"{worker.Age,5}#";
                note += $"{worker.Hieght,5}#";
                note += $"{worker.DateOfBirth.ToShortDateString(),20}#";
                note += $"{worker.PlaceOfBirth,15}";
                sw.Write($"{note}\n");
                sw.Close();
            }
        }
        public List<Worker> GetAllWorkers()
        {
            if (!File.Exists(fileName))
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
                {

                }
            }
                List<Worker> workers = new List<Worker>();
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('#');
                    Worker worker = new Worker(Convert.ToInt32(data[0]), Convert.ToDateTime(data[1]), data[2], data[3],
                        data[4], Convert.ToDateTime(data[5]), data[6]);
                    workers.Add(worker);

                }
                sr.Close();
            }
            return this.workers = workers;
        }
        public Worker GetWorkerById(string id)
        {
            GetAllWorkers();
            int count=0;
            foreach (var item in workers)
            {
                if (item.Id.Equals(Convert.ToInt32(id)))
                {

                count++;
                return item;

                }
                else if (count >0)
                {
                Console.WriteLine("Запись не найдена");
                }

            }
            return new Worker(-1,new DateTime(),null,null,null,new DateTime(),null);
        }
        public List<Worker> GetWorkersInRange(DateTime from, DateTime to)
        {
            List<Worker> matchedWorkers = new List<Worker>();
            GetAllWorkers();
            foreach (var item in workers)
            {
                if (item.DateOfNote >= from && item.DateOfNote <= to)
                {
                    matchedWorkers.Add(item);
                }
            }
            if (matchedWorkers.Count == 0)
            {
                Console.WriteLine("Записи не найдены");
            }
            return matchedWorkers;
        }
        public void DeleteById(string id)
        {
            List<Worker> workers = GetAllWorkers();
            Worker workerForDelete = GetWorkerById(id);
            File.Delete(fileName);
            workers.Remove(workerForDelete);
            foreach (var item in workers)
            {
                AddWorker(item);
            }

        }
        static void MakeHeader()
        {
            Console.Write($"{"id",3}{"date",20}{"FIO ",20}{"Age ",5}{"Hieght ",5}{"birth day ",20}{"Birth Place ",15}\n");
        }
        public int GenerateID()
        {
            if (GetAllWorkers().Count!=0)
            {
                int id = GetAllWorkers().Last().Id + 1;
                return id;
            }
            return 0;
        }
        public void ShowNotesInConsole(IList<Worker> workers)
        {
            MakeHeader();
            foreach (var item in workers)
            {
                Console.WriteLine($"{item.Id,3} {item.DateOfNote,20} {item.FIO,15}" +
                    $" {item.Age,5} {item.Hieght,5} {item.DateOfBirth.ToShortDateString(),20} {item.PlaceOfBirth,15}");
            }
        }
        public void ShowWorker(Worker item)
        {
            Console.WriteLine($"{item.Id,3} {item.DateOfNote,20} {item.FIO,15}" +
                    $" {item.Age,5} {item.Hieght,5} {item.DateOfBirth.ToShortDateString(),20} {item.PlaceOfBirth,15}");
        }


    }
}
