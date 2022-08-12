using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Devide_String
{
    class Program
    {
        static void Main(string[] args)
        {
           string longSentence = Console.ReadLine();

            ShowWords(DevideWordsBySpace(longSentence));
            Console.ReadKey();



        }
        static string [] DevideWordsBySpace (string longSentence)
        {
            return longSentence.Split(' ');
        }
        static void ShowWords(string[] arrayOfWords)
        {
            foreach (var item in arrayOfWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}
