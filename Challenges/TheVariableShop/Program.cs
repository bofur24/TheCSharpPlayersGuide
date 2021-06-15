using System;

namespace TheVariableShop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Objectives
             
            Build a program with a variable of all fourteen types described in this level
            Assign each of them a value using a literal of the correct type.
            use Console.WriteLine to display the contents of each variable.     
             */
            int aInt = 5;
            uint aUInt = 5;

            short aShort = 5;
            ushort aUShort = 5;

            long aLong = 5;
            ulong aULong = 5;

            byte aByte = 5;
            sbyte aSByte = 5;

            char aChar = 'a';
            string aString = "Name";

            bool aBool = true;

            float aFloat = 5.0f;
            double aDouble = 5.0;
            decimal adecimal = 5.0m;

            Console.WriteLine("The Variable Shop");
            Console.WriteLine("int = " + aInt);
            Console.WriteLine("uint = " + aUInt);
            Console.WriteLine("short = " + aShort);
            Console.WriteLine("ushort = " + aUShort);
            Console.WriteLine("long = " + aLong);
            Console.WriteLine("ulong = " + aULong);
            Console.WriteLine("byte = " + aByte);
            Console.WriteLine("sbyte = " + aSByte);
            Console.WriteLine("char = " + aChar);
            Console.WriteLine("string = " + aString);
            Console.WriteLine("bool = " + aBool);
            Console.WriteLine("float = " + aFloat);
            Console.WriteLine("double = " + aDouble);
            Console.WriteLine("decimal = " + adecimal);
        }
    }
}
