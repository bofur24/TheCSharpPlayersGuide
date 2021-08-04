using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            // var score = ("R2-D2", 12420, 15);

            // (string Name, int Points, int Level) score = ("R2-D2", 12420, 15);

            //Console.WriteLine($"Name:{score.Name} Level: { score.Level} Score: {score.Points}");


            (string One, int Two, int Three) score = GetScore();
            DisplayScore(score);

            (string N, int P, int L) GetScore() => ("R2-D2", 12420, 15);

            void DisplayScore((string Name, int Points, int Level) score)
            {
                Console.WriteLine($"Name:{score.Name} Level{score.Level} Score{score.Points}");
            }

            (string Name, int Points, int Level)[] CreateHighScores()
            {
                return new (string, int, int)[3]
                {
                    ("R2-D2", 12420, 15),
                    ("C-3PO", 8543, 9),
                    ("GONK", -1, 1)
                };

            }
           
        }




    }
}
