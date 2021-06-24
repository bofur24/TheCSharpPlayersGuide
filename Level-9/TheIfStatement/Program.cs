using System;

namespace TheIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your score? ");
            string inpput = Console.ReadLine();
            int score = Convert.ToInt32(inpput);
            Char letterGrade;
            if (score == 100)
            {
                letterGrade = 'A';
                Console.WriteLine("A+! Perfect score! " + letterGrade);
            }
            else
            {                
                letterGrade = 'B';
                Console.WriteLine("Try again. " + letterGrade);
            }
        }
    }
}
