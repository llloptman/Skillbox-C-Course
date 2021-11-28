using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomeWork
{
    class FirstTask
    {
        static void Main(string[] args)
        {
            string fullName = "James Howlett";
            int age = 197;
            string email = "Logan@wolwerine.com";
            float bProgramming = 2.7f;
            double bMath = 5;
            decimal bPhysics = 4.9m;

            string pattern = $"Ф.И.О: {fullName}\n" +
                             $"Возраст: {age}\n" +
                             $"Email: {email}\n" +
                             $"Баллы по программированию: {bProgramming}\n" +
                             $"Баллы по математике: {bMath}\n" +
                             $"Баллы по физике: {bPhysics}";

            Console.WriteLine(pattern);
            Console.ReadKey();
        }
    }
}
