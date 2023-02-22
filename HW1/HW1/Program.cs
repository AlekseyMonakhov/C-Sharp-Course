using System;

namespace Less2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first operand");
            string firstOperand = Console.ReadLine();

            Console.WriteLine("enter operation");
            string operation = Console.ReadLine();

            Console.WriteLine("enter second operand");
            string secondOperand = Console.ReadLine();



            Console.WriteLine("is reversed");
            string isReverse = Console.ReadLine();
            bool isReverseBool = isReverse == "true" ? true: false;
           



            Console.WriteLine(Calculate(float.Parse(firstOperand), float.Parse(secondOperand), operation, isReverseBool));
        }
        static float Calculate(float firstOperant, float secndOperant, string operation, bool isRevers = false)
        {
            if (operation == "+")
            {
                return firstOperant + secndOperant;
            }

            if (operation == "-")
            {
                return firstOperant - secndOperant;
            }

            if (operation == "/")
            {
                return isRevers ? secndOperant / firstOperant : firstOperant / secndOperant;
            }

            return firstOperant * secndOperant;
        }


    }
}