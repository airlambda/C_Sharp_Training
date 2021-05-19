using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BasicAlgo
{
    class Exercise49
    {
        static void Main(string[] args)
        {
            // Write a program to check if n given numbers are in strict increasing order.
            // However, if a (n+1)th parameter is set to True, equality between two numbers is allowed

            // For this exercise, we are going to have a Main method which only takes in user input
            // then displays the output.
            // The actual calculation will be in a separate method called CheckOrder

            // Get user input
            Console.WriteLine("Enter a comma separated string of values and either True or False at the end to enable equality");
            var UserInput = Console.ReadLine();
            var InputArray = StringSplitArray(UserInput);
            CheckOrder(InputArray);
        }
        /*
        static List<string> ParseInput(string UserInput)
        {
            // Helper function to parse string from user input to bools and ints
            // Set up return variable
            List<string> ReturnedStringList = new List<string>();
            
            // First use the regex library to parse the input
            var RegexString = @"[0-9a-zA-Z.]+(,[0-9a-zA-Z]+)*";

            Regex rx = new Regex(RegexString, RegexOptions.Compiled | RegexOptions.IgnoreCase);

            MatchCollection matches = rx.Matches(UserInput);

            foreach (Match match in matches)
            {
                ReturnedStringList.Add(match.Value);
            }
            ReturnedStringList.ForEach(Console.WriteLine);
            return ReturnedStringList;
        }
        */
        static string[] StringSplitArray(string UserInput)
        {
            // Helper function that does the job of ParseInput but much simpler
            char[] delimiterChars = { ' ', ','};
            string[] ReturnedArray = UserInput.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            return ReturnedArray;
        }
        public static bool IsIncreasingMonotonically<T>(List<T> list) where T : IComparable
        {
            return list.Zip(list.Skip(1), (a,b) => a.CompareTo(b) <= 0).All(b => b);
        }
        public static bool IsStrictlyIncreasingMonotonically<T>(List<T> list) where T : IComparable
        {
            return list.Zip(list.Skip(1), (a,b) => a.CompareTo(b) < 0).All(b => b);
        }
        static void CheckOrder(string[] InputStringArray)
        {
            // Parse user input
            // Function is expecting a string array
            // We need to parse the contents of the string array into ints and one bool
            int number;
            List<int> ComparisonList = new List<int>();
            bool equality;
            bool EnableEquality = false;

            foreach (var item in InputStringArray)
            {
                if (int.TryParse(item, out number))
                {
                    ComparisonList.Add(number);
                }
                if (bool.TryParse(item, out equality))
                {
                    EnableEquality = equality;
                }
            }
            // Now run the comparison according to the EnableEquality bool
            if (EnableEquality)
            {
                bool result = IsIncreasingMonotonically(ComparisonList);
                Console.WriteLine(result);
            }
            else
            {
                bool result = IsStrictlyIncreasingMonotonically(ComparisonList);
                Console.WriteLine(result);
            }
        }
    }
}