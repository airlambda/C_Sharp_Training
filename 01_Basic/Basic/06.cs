using System;

namespace Basic
{
    class Exercise06
    {
        static void Main(string[] args)
        {
            string UserInput;
            Console.WriteLine("Please enter the first number to be multiplied:");
            UserInput = Console.ReadLine();
            decimal FirstNumber = Convert.ToDecimal(UserInput);

            Console.WriteLine("Please enter the second number to be multiplied:");
            UserInput = Console.ReadLine();
            decimal SecondNumber = Convert.ToDecimal(UserInput);

            Console.WriteLine("Please enter the third number to be multiplied:");
            UserInput = Console.ReadLine();
            decimal ThirdNumber = Convert.ToDecimal(UserInput);

            decimal OutputNumber = FirstNumber * SecondNumber * ThirdNumber;
            Console.WriteLine("The three numbers multiplied equals: " + OutputNumber);
        }
    }
}