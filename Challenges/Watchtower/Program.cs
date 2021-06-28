using System;

namespace Watchtower
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Objectives:
                Ask the user for an x value and ay value. These are the coordinates of the enemy 
                relative to the watchtower's location.
                Using the image on the right, if statements, and relational operators, display a 
                message about what direction the enemy is coming from. For example, "The enemy is to the northwest!"
                or "The enemy is here!"
             */
            Console.Write("Enter the x coordinate ");
            string cordXText = Console.ReadLine();
            int cordX = Convert.ToInt32(cordXText);

            Console.Write("Enter the y coordinate ");
            string cordYText = Console.ReadLine();
            int cordY = Convert.ToInt32(cordYText);

            if (cordX < 0 && cordY > 0)
            {
                Console.WriteLine("The enemy is to the Northwest!");
            }
            else if (cordX == 0 && cordY > 0)
            {
                Console.WriteLine("The enemy is to the North!");
            }
            else if (cordX > 0 && cordY > 0)
            {
                Console.WriteLine("The enemy is to the Northeast!");
            }
            else if (cordX < 0 && cordY == 0)
            {
                Console.WriteLine("The enemy is to the West!");
            }
            else if (cordX == 0 && cordY == 0)
            {
                Console.WriteLine("The enemy here!");
            }
            else if (cordX > 0 && cordY == 0)
            {
                Console.WriteLine("The enemy is to the East!");
            }
            else if (cordX < 0 && cordY < 0)
            {
                Console.WriteLine("The enemy is to the Southwest!");
            }
            else if (cordX == 0 && cordY < 0)
            {
                Console.WriteLine("The enemy is to the South!");
            }
            else if (cordX > 0 && cordY < 0)
            {
                Console.WriteLine("The enemy is to the Southeast!");
            }
        }
    }
}
