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
            rep1.AddWorker();
            rep1.ShowNotesInConsole();



        }
    }
}
