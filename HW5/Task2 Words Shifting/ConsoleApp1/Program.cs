using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string longSentence = Console.ReadLine();
            ReverseWords(longSentence);
            Console.ReadKey();

        }
        static string[] DevideWordsBySpace(string longSentence)
        {
            return longSentence.Split(' ');
        }
        static void ReverseWords (string inputPhrase)
        {
            string result = "";
            for (int i = DevideWordsBySpace(inputPhrase).Length-1; i >= 0; i--)
            {
                result += DevideWordsBySpace(inputPhrase)[i] + " ";
            }
            Console.WriteLine(result);
        }
    }
}
