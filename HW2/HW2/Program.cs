using System;

namespace Less2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            float firstOperand;
            string operation;
            float secondOperand;
            string isReverse;
            bool isReverseBool;
            bool isError;
            do
            {
                try
                {
                    Console.WriteLine("enter first operand");
                    firstOperand = float.Parse(Console.ReadLine());

                    Console.WriteLine("enter operation");
                    operation = Console.ReadLine();

                    switch (operation) 
                    {
                        case "sqrt":
                            Console.WriteLine(Calculate(firstOperand, 0, operation));
                            isError = false;
                            break;

                        case "/":
                            Console.WriteLine("enter second operand");
                            secondOperand = float.Parse(Console.ReadLine());

                            Console.WriteLine("is reversed");
                            isReverse = Console.ReadLine();
                            isReverseBool = isReverse == "true" ? true : false;
                            Console.WriteLine(Calculate(firstOperand, secondOperand, operation, isReverseBool));
                            isError = false;
                            break;

                        default:
                            Console.WriteLine("enter second operand");
                            secondOperand = float.Parse(Console.ReadLine());


                            Console.WriteLine(Calculate(firstOperand, secondOperand, operation));
                            isError = false;
                            break;
                    }

                }
                catch (Exception ex)
                {
                    isError = true;
                }

            }
            while (isError);



        }
        static float Calculate(float firstOperant, float secndOperant, string operation, bool isRevers = false)
        {
            switch (operation) 
            {
                case "-":
                    return firstOperant - secndOperant;

                case "+":
                    return firstOperant + secndOperant;
                
                case "*":
                    return firstOperant * secndOperant;
                
                case "/":
                    return isRevers ? secndOperant / firstOperant : firstOperant / secndOperant;
                case "^":
                    return Convert.ToInt32(Math.Pow(firstOperant, secndOperant));
                case "sqrt":    
                    return Convert.ToInt32(Math.Sqrt(firstOperant));

                default:
                    return 0;
            }
        }


    }
}