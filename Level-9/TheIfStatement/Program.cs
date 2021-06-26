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
            //Char letterGrade;
            /*if else statements
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
            */
            /*else if statments
            if (score == 100)
            {
                Console.WriteLine("A+! Perfect Score!");
            } else if (score == 99)
            {
                Console.WriteLine("Missed it by THAT much.");  // Get Smart reference, anyone?
            }else if (score == 42)
            {
                Console.WriteLine("Oh no, not again.");
            }
            else
            {
                Console.WriteLine("Try again.");
            }
            */
            //Relational Operators
            if (score >= 90)
            {
                Console.WriteLine("A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
            Console.Write("How many points have you scored? ");
            string input = Console.ReadLine();
            int scored = Convert.ToInt32(input);

            int pointsNeededToPass = 100;
            bool levelComplete;

            if (scored >= pointsNeededToPass)
            {
                levelComplete = true;
            }
            else
            {
                levelComplete = false;
            }

            if (levelComplete)
            {
                Console.WriteLine("You've beaten the level!");
            }
            else
            {
                Console.WriteLine("Try again!!");
            }

            /*
             Shorter way is to run it this way
            bool levelComplete = score >= pointsNeededToPass;
             
             */

        }
    }
}
