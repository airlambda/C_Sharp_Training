using System;

namespace BasicAlgo
{
    class Exercise28
    {
        static void Main(string[] args)
        {
            // Write a program to check if the first appearance of "a" in a given string
            // is immediately followed by another "a"

            // Get user input for string
            Console.WriteLine("Please enter string to be processed:");
            string UserInput = Console.ReadLine();

            // Define char to be matched
            char CharMatch = 'a';

            // Start iterating through string for char
            char[] CharArray = UserInput.ToCharArray();
            int itr = 0;
            bool EndCondition = false;
            while (itr < CharArray.Length)
            {
                if (CharArray[itr] == CharMatch && !(itr == CharArray.Length - 1))
                {
                    if (CharArray[itr+1] == CharMatch)
                    {
                        EndCondition = true;
                        break;   
                    }
                }
                itr++;
            }

            // Print out result
            Console.WriteLine(EndCondition);   
        }
    }
}
