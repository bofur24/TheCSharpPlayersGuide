using System;

namespace Classess
{
    class Program
    {
        static void Main(string[] args)
        {

            Score best = new Score();

            best.name = "R2 D2";
            best.points = 12420;
            best.level = 15;

            Score b = new Score();
            b.name = "C-3P0";
            b.points = 8543;
            b.level = 8;


            if (best.EarnedStar())
            {
                Console.WriteLine($"{best.name} earned a star!");
            }
            if (b.EarnedStar())
            {
                Console.WriteLine($"{b.name} earned a star!");
            }



        }
                class Score
                {

                public string name;
                public int points;
                public int level;

                public Score()
                {
                name = "Unknown";
                points = 0;
                level = 1;
                }

                public bool EarnedStar() => (points / level) > 100;
                }
         }
    }
        

