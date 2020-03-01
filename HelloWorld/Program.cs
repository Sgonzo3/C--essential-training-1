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

            int mathX = 5;
            int mathY = 10;
            int mathZ = 15;
            int mathA = mathX + mathY;
            int mathB = mathY * mathZ;
            int mathC = mathZ - mathX;
            bool isEvenX = (mathX % 2) == 0;
            bool notDivisibleBy3Y = (mathY % 3 == 0);
            double roundDouble(double input)
            {
                decimal newNumber = (decimal)input;
                newNumber = Math.Round(newNumber, 3);
                return (double)newNumber;
            } 
            Console.WriteLine(mathX + ", " + mathY + ", " + mathZ + ", " + mathA + ", " + mathB + ", " + mathC + ", " + isEvenX + ", " + notDivisibleBy3Y + ", " + roundDouble(2.345199));
            Console.ReadKey();

            int convertX = 100;
            int convertY = 200;
            int convertZ = 300;
            double convertA = 1000;
            double convertB = 2000;
            double convertC = 3000;

            double convertedX = (double)convertX;
            double convertedY = (double)convertY;
            double convertedZ = (double)convertZ;
            int convertedA = (int) convertA;
            int convertedB = (int) convertB;
            int convertedC = (int) convertC;

            Console.WriteLine(convertedX + ", " + convertedY + ", " + convertedZ + ", " + convertedA + ", " + convertedB + ", " + convertedC);
            Console.ReadKey();

        }
    }
}
