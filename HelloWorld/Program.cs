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
            int x = 5;
            double y = 5.5;
            char z = 'z';
            string word = "Something";

            Console.WriteLine(myBool + ", " + x + ", " + y + ", " + z + ", " + word);
            Console.ReadKey();

            int maxVal = int.MaxValue;
            Console.WriteLine(maxVal);
            Console.ReadKey();
            maxVal++;
            Console.WriteLine(maxVal); // becomes negative value
            Console.ReadKey();


        }
    }
}
