using System;

namespace SimulasTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Objectives:
                Define an enumeration for the stat of the chest
                Make a variable whose type is this new enumeration.
                Write code to allow you to manipulate the chest with the lock, unlock, open, and close commands,
                but ensure that you don't transition between stats that don't support it.
                Loop forever, asking for the next command  

                locked / unlocked
                closed / open
                open / closed
                closed / locked
             
             */
            Console.WriteLine("Chest options are Unlock, Open, Close, or Lock");
            ChestState currentState = ChestState.LOCKED;

            while (true)
            {
                Console.Write($"The chest is {currentState}. What do you want to do? ");

                String input = Console.ReadLine().ToUpper();

                if (true)
                {
                    if (currentState == ChestState.LOCKED && input == "UNLOCK") currentState = ChestState.CLOSED;
                    if (currentState == ChestState.CLOSED && input == "OPEN") currentState = ChestState.OPEN;
                    if (currentState == ChestState.OPEN && input == "CLOSE") currentState = ChestState.CLOSED;
                    if (currentState == ChestState.CLOSED && input == "LOCK") currentState = ChestState.LOCKED;
                }
            }
            
            

         


          
        }

        enum ChestState { OPEN, CLOSED, LOCKED}
    }
}
