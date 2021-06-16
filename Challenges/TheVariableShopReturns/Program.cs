using System;

namespace TheVariableShop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Objectives
             
            Modify your Variable Shop program to assign a new, different literal value to
            each of the 14 original variables. Do not declare any additional variables.
            Use Console.WriteLine to display the updated contents of each variable.
             */
            int aInt = 5;
            aInt = 6;
            uint aUInt = 5;
            aUInt = 6;

            short aShort = 5;
            aShort = 6;
            ushort aUShort = 5;
            aUShort = 6;

            long aLong = 5;
            aLong = 6;
            ulong aULong = 5;
            aULong = 6;

            byte aByte = 5;
            aByte = 6;
            sbyte aSByte = 5;
            aSByte = 6;

            char aChar = 'a';
            aChar = 'b';
            string aString = "Name";
            aString = "UserName";

            bool aBool = true;
            aBool = false;

            float aFloat = 5.0f;
            aFloat = 6.0f;
            double aDouble = 5.0;
            aDouble = 6.0;
            decimal adecimal = 5.0m;
            adecimal = 6.0m;

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
