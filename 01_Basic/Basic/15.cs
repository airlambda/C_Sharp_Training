using System;
using System.Text;

namespace Basic
{
    class Exercise15
    {
        static void Main(string[] args)
        {
            // Take in user specified string
            string InputString;
            Console.WriteLine("Type in string to be processed: ");
            InputString = Console.ReadLine();

            // Take in index to remove char from
            int Index;
            string IndexAsStr;
            Console.WriteLine("Enter index of word to remove char from: ");
            IndexAsStr = Console.ReadLine();

            // Run checks on index and word length to make sure it makes sense
            if (string.IsNullOrEmpty(InputString))
            {
                Console.WriteLine("Please enter a string to process");
                InputString = Console.ReadLine();
            }
            if (string.IsNullOrEmpty(IndexAsStr))
            {
                Console.WriteLine("Please enter an index for the processing");
                IndexAsStr = Console.ReadLine();
            }
            while (!int.TryParse(IndexAsStr, out Index) || InputString.Length < Index)
            {
                Console.WriteLine("This is not a valid integer, please enter a valid integer");
                IndexAsStr = Console.ReadLine();
            }

            // Run the actual string slicing now
            char[] CharArray;
            StringBuilder OutputString = new StringBuilder();
            CharArray = InputString.ToCharArray();
            for (int ctr = 0; ctr <= CharArray.Length; ctr++)
            {
                if (ctr == (Index-1))
                {
                    continue;
                }
                else
                {
                    OutputString.Append(CharArray[ctr]);
                }
            }

            // Display result
            Console.WriteLine("The processed string is: " + OutputString);
        }
    }
}
