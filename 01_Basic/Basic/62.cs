using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Basic
{
    class Exercise62
    {
        static void Main(string[] args)
        {
            // Write a program to reverse the strings contained in each pair of parentheses
            // in a given string, and also remove the parentheses within the given string

            // Get user input
            string UserInput;
            Console.WriteLine("Please enter string for processing: ");
            UserInput = Console.ReadLine();

            // Get positions of opening and closing parentheses
            List<int> OpeningParentheses = new List<int>();
            List<int> ClosingParentheses = new List<int>();
            string RegexOpeningParenthesis = @"\(";
            string RegexClosingParenthesis = @"\)";

            foreach (Match match in Regex.Matches(UserInput, RegexOpeningParenthesis))
            {
                OpeningParentheses.Add(match.Index);
            }

            foreach (Match match in Regex.Matches(UserInput, RegexClosingParenthesis))
            {
                ClosingParentheses.Add(match.Index);
            }

            // Prep structures for string manipulation and output
            char[] CharArray = UserInput.ToCharArray();
            StringBuilder OutputString = new StringBuilder();

            // Do string reversal for chars within parentheses
            int idx = 0;
            int ParenthesisIndex = 0;
            while (idx < CharArray.Length)
            {
                if (OpeningParentheses.Contains(idx))
                {
                    // Find index of closing parenthesis for the current pair of parentheses
                    int EndParenthesisChar = ClosingParentheses[ParenthesisIndex];

                    // Create a new subset with the chars that we need to reverse
                    char[] subset = new ArraySegment<char>(CharArray, idx+1, (EndParenthesisChar-idx-1)).ToArray();
                    
                    // IMPORTANT: Array.Reverse does an in-place reverse on the array passed into it
                    // hence does not need a variable to hold the results from reverse.
                    Array.Reverse(subset);

                    // Output results and increment idx according to how far we've jumped to find the closing parenthesis
                    // as well as incrementing the parenthesis index.
                    OutputString.Append(subset);
                    idx = EndParenthesisChar + 1;
                    ParenthesisIndex++;
                }
                else
                {
                    OutputString.Append(CharArray[idx]);
                    idx++;
                }
            } 

            // Show result
            Console.WriteLine(OutputString);
        }
    }
}