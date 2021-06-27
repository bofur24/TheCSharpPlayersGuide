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
            /*Relational Operators
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
            */
            /*
             Shorter way is to run it this way
            bool levelComplete = score >= pointsNeededToPass;
             
             */
            /* Logical Operators
            int pointsNeededToPass = 100;
            bool levelComplete = score >= pointsNeededToPass;

            if (!levelComplete)
            {
                Console.WriteLine("This level is not over yet!");
            }

            int shields = 50;
            int armor = 20;

            if (shields <= 0 && armor <= 0)
            {
                Console.WriteLine("You're dead");
            }

            if (shields > 0 || armor > 0)
            {
                Console.WriteLine("You're still alive! Keep going!");
            }

            bool stillHasShields = shields > 0;
            bool stillHasArmor = armor > 0;

            if (stillHasShields || stillHasArmor)
            {
                Console.WriteLine("You're still alive! Keep going!");
            }
            */
            /* Nesting IF Statements

            int shields = 50;
            int armor = 20;

            if (shields <= 0)
            {
                if (armor <= 0)
                {
                    Console.WriteLine("Shields and armor at Zero! You're dead!");
                }
                else
                {
                    Console.WriteLine("Shields are gone, but armor is keeping you alive!");
                }
            }
            else
            {
                Console.WriteLine("You still have shields left. The world is safe.");
            }
            */
            //The Conditional Operator

            string textToDisplay = score > 70 ? "You passed!" : "You failed.";
            Console.WriteLine(textToDisplay);
        }
    }
}
