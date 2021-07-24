using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string:");
            string line = Console.ReadLine();
            line = line.ToLower().Trim();
            string outputStr = String.Empty;
            Console.WriteLine("You entered " + line);
            for (var i = 0; i < line.Length; i++)
            {
                outputStr += char.ToUpper(line[i]);
                for (var j = 0; j < i; j++)
                {
                    outputStr += line[i];
                }
                if (i < line.Length - 1)
                {
                    outputStr += '-';
                }
            }
            Console.WriteLine(outputStr);
            Console.WriteLine("Enter any key to exit");
            Console.ReadKey();
        }
    }
}
