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
    

        public Repository()
        {
            workers = new List<Worker>();
            fileName = "default note.txt";
        }
        public string SetFileName() {
           return fileName = "Emloees Note.txt";
        }

        public void AddWorker()
        {
            Worker worker = new Worker(GenerateID());
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
        static void MakeHeader()
        {
            Console.Write($"{"id",3}{"date",20}{"FIO ",20}{"Age ",5}{"Hieght ",5}{"birth day ",20}{"Birth Place ",15}\n");
        }

        private int GenerateID()
        {
            if (GetAllWorkers().Count!=0)
            {
                int id = GetAllWorkers().Last().Id + 1;
                return id;
            }
            return 0;
        }

        public void ShowNotesInConsole()
        {
            MakeHeader();
            foreach (var item in GetAllWorkers())
            {
                Console.WriteLine($"{item.Id} {item.DateOfNote} {item.FIO}" +
                    $" {item.Age} {item.Hieght} {item.DateOfBirth.ToShortDateString()} {item.PlaceOfBirth}");
            }
            Console.ReadKey();
        }


    }
}
