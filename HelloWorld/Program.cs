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

            string escapeSequence = "Some text on line one \n Some text on line two";
            Console.WriteLine(escapeSequence);
            Console.ReadKey();

            string literalString = @"A line of text that will print as written
on multiple lines, without needing to use escape sequences.";
            Console.WriteLine(literalString);
            Console.ReadKey();

            string stringOne = "This is a ";
            string stringTwo = "Concatenated String.";
            string concatenatedSentance = stringOne + stringTwo;
            Console.WriteLine(concatenatedSentance);
            Console.ReadKey();

            string stringWithLength = "Some string of Text.";
            stringWithLength = stringWithLength + " Length:" + stringWithLength.Length;
            Console.WriteLine(stringWithLength);
            Console.ReadKey();

            string oddString = "seventy";
            char firstLetter = oddString[0];
            char secondLetter = oddString[(oddString.Length / 2)];
            char lastLetter = oddString[oddString.Length - 1];
            string firstMiddleLast = firstLetter.ToString() + secondLetter.ToString() + lastLetter.ToString();
            Console.WriteLine(firstMiddleLast);
            Console.ReadKey();

            string caseChange = "Alphabet";
            string caseChangeUpper = caseChange.ToUpper();
            string caseChangeLower = caseChange.ToLower();
            Console.WriteLine(caseChange + " " + caseChangeUpper + " " + caseChangeLower);
            Console.ReadKey();

            string wholeString = "Hypothetical";
            string wholeSecondString = "Certain";
            Console.WriteLine(wholeString.Substring(1, wholeString.Length-2) + " " + wholeSecondString.Substring(1, wholeSecondString.Length -2));
            Console.ReadKey();
            Console.WriteLine(wholeString.Remove(wholeString.Length - 1).Remove(0, 1) + " " + wholeSecondString.Remove(wholeSecondString.Length - 1).Remove(0, 1));
            Console.ReadKey();

            string searchX = "civilization";
            char searchY = 'z';
            int searchIndex = searchX.IndexOf(searchY);
            bool searchIfPresent = searchX.Contains(searchY);
            string fakePath = @"c:\foo\bar.txt";
            char backSlash = '\\';
            int firstSemiColon = fakePath.IndexOf(':');
            int lastBackSlash = fakePath.LastIndexOf(backSlash) + 1;
            int firstDot = fakePath.IndexOf('.');
            string fileName = fakePath.Substring(lastBackSlash, firstDot - lastBackSlash);
            string driveName = fakePath.Substring(0, firstSemiColon);
            Console.WriteLine(searchIndex + " " + searchIfPresent + " " + fileName + " " + driveName);
            Console.ReadKey();

            string splittingX = "A story starts at the beginning.";
            string[] splitX = splittingX.Split();
            Console.WriteLine(splitX);
            Console.ReadKey();

        }
    }
}
