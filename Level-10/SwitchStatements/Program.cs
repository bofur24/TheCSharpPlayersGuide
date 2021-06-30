using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avast, matey! What be ye desire?");
            Console.WriteLine("1 - Rest");
            Console.WriteLine("2 - Pillage the port");
            Console.WriteLine("3 - Set sail");
            Console.WriteLine("4 - Release the Kraken");
            Console.Write("What be the plan, Captain? ");
            string choiceText = Console.ReadLine();
            int choice = Convert.ToInt32(choiceText);

            /*
            If stament options
            

            if (choice == 1)
            {
                Console.WriteLine("Ye rest and recover your health.");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Raiding the port town get ye 50 gold doubloons.");
            }
            else if (choice == 3)
            {
                Console.WriteLine("The wind is at your back; the open horizon ahead.");
            }
            else if (choice == 4)
            {
                Console.WriteLine("\'Tis but a bay Kraken, but still eats toy boats.\'");
            }
            else
            {
                Console.WriteLine("Apologies. I do not know that one.");
            }
            */
            /*
             Switch Statement
             */
            /*switch (choice)
            {
                case 1:
                    Console.WriteLine("Ye rest and recover your health.");
                    break;
                case 2:
                    Console.WriteLine("Raiding the port town get ye 50 gold doubloons.");
                    break;
                case 3:
                    Console.WriteLine("The wind is at your back; the open horizon ahead.");
                    break;
                case 4:
                    Console.WriteLine("\'Tis but a bay Kraken, but still eats toy boats.\'");
                    break;
                default:
                    Console.WriteLine("Apologies. I do not know that one.");
                    break;
            }
            */
            // Switch Expressions
            string response;

            response = choice switch
            {
                1 => "Ye rest and recover your health",
                2 => "Raiding the port town get ye 50 gold doubloons.",
                3 => "The wind is at your back; the open horizon ahead.",
                4 => "Tis but a baby Kraken, but still eats toy boats.",
                _ => "Apologies. I do not know that one."
            };

            Console.WriteLine(response);



















        }
    }
}
