using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RunCalculator();
        }

        public static void RunCalculator()
        {
            Console.WriteLine("\n Use number keys to select desired operation");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division \n");
            int action = Convert.ToInt32(Console.ReadLine());

            switch (action)
            {
                case 1:
                    {
                        Console.WriteLine("\n Add \n");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\n Subtract \n");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\n Multiply \n");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("\n Divide \n");
                        break;
                    }
            }

            Console.WriteLine("Enter 1st input");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            switch (action)
            {
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = Division(input_1, input_2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid selection, try again");
                        break;
                    }
            }
            Console.WriteLine("\n *** The result is {0} *** \n", result);

            Console.WriteLine("Continue? Y/N \n");
            string stopCalculator = Console.ReadLine();
            if (stopCalculator.ToLower() == "n")
            {
                return;
            }

            RunCalculator();
        }

        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }

        public static int Subtraction(int input_1, int input_2)
        {
            int result = input_1 - input_2;
            return result;
        }

        public static int Multiplication(int input_1, int input_2)
        {
            int result = input_1 * input_2;
            return result;
        }

        public static int Division(int input_1, int input_2)
        {
            int result = input_1 % input_2;
            return result;
        }
    }
}
