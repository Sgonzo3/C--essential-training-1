using System;

namespace HelloWorld
{
    
    public class Enumerations
    {
        public enum weekdays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday

        }

        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }
    }
    public class Structs
    {
        public struct myStruct
        {
            public string name;
            public int age;
        }
    }
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

            const string formatX = "The {0} {1} over the fence.";
            string formatY = String.Format(formatX, "dog", "jumped");
            Console.WriteLine(formatY);
            Console.ReadKey();

            bool parsingA = true;
            int parsingB = 6;
            double parsingC = 8.91;
            char parsingD = 'x';
            string parsingW = parsingA.ToString();
            string parsingX = parsingB.ToString();
            string parsingY = parsingC.ToString();
            string parsingZ = parsingD.ToString();
            bool parsingE = bool.Parse(parsingW);
            int parsingF = int.Parse(parsingX);
            double parsingG = double.Parse(parsingY);
            char parsingH = char.Parse(parsingZ);
            Console.WriteLine(parsingE);
            Console.ReadKey();
            Console.WriteLine(parsingF);
            Console.ReadKey();
            Console.WriteLine(parsingG);
            Console.ReadKey();
            Console.WriteLine(parsingH);
            Console.ReadKey();

            var bestDay = HelloWorld.Enumerations.weekdays.Saturday;
            Console.WriteLine(bestDay + " " + (int)bestDay);
            Console.ReadKey();

            var structX = new Structs.myStruct();
            var structY = new Structs.myStruct();
            structX.name = structY.name;
            structX.age = structY.age;
            Console.WriteLine(structX.name + ' ' + structX.age);
            Console.ReadKey();

            void consoleApp()
            {
                Console.WriteLine("Enter First Name...");
                Console.ReadLine();
                Console.WriteLine("Enter Middle Name...");
                Console.ReadLine();
                Console.WriteLine("Enter Last Name...");
                Console.ReadLine();
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            consoleApp();

            //CommandLine
            // todo

            // Part 2
            // Conditionals
            //if/else
            string ifElse(int conditionalX)
            {
                if (conditionalX < 100)
                {
                    return "x is less than 100";
                }
                else if (conditionalX == 100)
                {
                    return "x is 100";
                }
                else
                {
                    return "x is greater than 100";
                }

            }
            Console.WriteLine(ifElse(1));
            Console.WriteLine(ifElse(100));
            Console.WriteLine(ifElse(1000));
            Console.ReadKey();

            // switch
            var weekday = Enumerations.weekdays.Saturday;

            switch (weekday.ToString())
            {
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("It's the weekend.");
                    Console.ReadKey();
                    break;
                case "Monday":
                    Console.WriteLine("Just starting.");
                    Console.ReadKey();
                    break;
                case "Tuesday":
                    Console.WriteLine("Still going.");
                    Console.ReadKey();
                    break;
                case "Wednesday":
                    Console.WriteLine("Halfway.");
                    Console.ReadKey();
                    break;
                case "Thursday":
                    Console.WriteLine("Almost there.");
                    Console.ReadKey();
                    break;
                case "Friday":
                    Console.WriteLine("About Done.");
                    Console.ReadKey();
                    break;
            }

            // order of operations
            string operationCheck( string s)
            {
                if ((s.Length < 5 && s.Length % 2 != 0) || (s.Length >= 10 && s.Length % 2 == 0))
                {
                    return s + " meets this condition.";
                }
                else
                {
                    return s + " does not meeet the condition.";
                }
            }
            Console.WriteLine(operationCheck("hibiscus"));
            Console.WriteLine(operationCheck("Two"));
            Console.WriteLine(operationCheck("applesauce"));
            Console.ReadKey();

            // nested Conditionals
            string nestedConditional(string s)
            {
                if(s.Length < 5)
                {
                    if(s.Length % 2 != 0)
                    {
                        return s + " meets this condition.";
                    } else
                    {
                        return s + " does not meeet the condition.";
                    } 
                } else if (s.Length >= 10)
                {
                    if(s.Length % 2 == 0)
                    {
                        return s + " meets this condition.";
                    } else
                    {
                        return s + " does not meeet the condition.";
                    }
                } else
                {
                    return s + " does not meeet the condition.";
                }
            }
            Console.WriteLine(nestedConditional("hibiscus"));
            Console.WriteLine(nestedConditional("Two"));
            Console.WriteLine(nestedConditional("applesauce"));
            Console.ReadKey();

            // loops
            // while loop

            //while(true)
            //{
            //    Console.WriteLine("Bad");
            //    // repeats infinitely
            //}

            string loopString = "0123456789";
            int position = 0;
            while(position < loopString.Length)
            {
                if(loopString[position] % 2 != 0)
                {
                    Console.Write(loopString[position]);
                }
                position++;
            }


            // do while
            Console.WriteLine(" ");
            int doWhileCurrent = 0;
            do
            {
                if (loopString[doWhileCurrent] % 2 != 0)
                {
                    Console.Write(loopString[doWhileCurrent]);
                }
                doWhileCurrent++;
            }
            while (doWhileCurrent < loopString.Length);

            // for loop
            Console.WriteLine(" ");
            for (int i = 0; i < loopString.Length; i++)
            {
                if (loopString[i] % 2 != 0)
                {
                    Console.Write(loopString[i]);
                }
            }

            // forEach
            Console.WriteLine(" ");
            foreach (char number in loopString)
            {
                if (number % 2 != 0)
                {
                    Console.Write(number);
                }
            }

            // nested Loops
            // TODO
            Console.WriteLine(" ");
            string loopHat = "13579";

            foreach (char number in loopHat)
            {

            }

            // loop flow control
            string flowControlString = "screenshot";
            foreach (char letter in flowControlString)
            {
                if (flowControlString.Substring(1).Contains(letter))
                {
                    Console.WriteLine(flowControlString.Substring(1).IndexOf(letter) + 1);
                    break;
                } else
                {
                    continue;
                }
            }

            // Arrays
            // single dimensional Arrays
            int[] singleDimensionalArray = new int[10];
            int singleDimensionalCurrent = 0;
            int singleDimensionalSum = 0;
            while (singleDimensionalCurrent < singleDimensionalArray.Length)
            {
                singleDimensionalArray[singleDimensionalCurrent] = singleDimensionalCurrent + 1;
                singleDimensionalCurrent++;
            }
            for(var i = singleDimensionalArray.Length; i > 0; i--)
            {
                singleDimensionalSum += singleDimensionalArray[i - 1];
                Console.Write(singleDimensionalArray[i - 1]);
            }
            Console.WriteLine(' ');
            Console.WriteLine(singleDimensionalSum);
            Console.ReadKey();

            //multidimensionalArrays
            var multiDimesionalArray = new int[4, 4];
            for(var i = 0; i < 4; i++)
            {
                for(var j = 0; j < 4; j++)
                {
                    multiDimesionalArray[i, j] = i * j;
                }
            }
            foreach (int index in multiDimesionalArray)
            {
                Console.Write(index);
            }

        }
    }
}
