using System;

namespace HelloWorld
{
    class Program
    {
        /// <summary>
        /// An example XML comment
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // A single line comment

            /*
             * First line in multiline comment
             * Second line in multi line comment
            */
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            bool myBool = true;
            int myInt = 5;
            double myDouble = 5.5;
            char myChar = 'z';
            string myString = "Something";

            Console.WriteLine(myBool + ", " + myInt + ", " + myDouble + ", " + myChar + ", " + myString);
            Console.ReadKey();

            int maxVal = int.MaxValue;
            Console.WriteLine(maxVal);
            Console.ReadKey();
            maxVal++;
            Console.WriteLine(maxVal); // becomes negative value
            Console.ReadKey();

            var implicitBool = true;
            var implicitInt = 5;
            var implicitDouble = 5.5;
            var implicitChar = 'z';
            var implicitString = "Something";
            Console.WriteLine(implicitBool + ", " + implicitInt + ", " + implicitDouble + ", " + implicitChar + ", " + implicitString);
            Console.ReadKey();

            int x = 10; //will return final x value
            int y = 20; // will return final y value
            int z1 = x++; // will return current x value then increment that value
            int z2 = ++y; // will first increment y value then return it 
            Console.WriteLine(x + ", " + y + ", " + z1 + ", " + z2);
            Console.ReadKey();

        }
    }
}
