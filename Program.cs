using System.Linq.Expressions;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne;
            int numTwo;
            int result;
            string calculateAgain;
            double divisonResult;
   
            do
            {
                try
                {
                    Console.WriteLine("Enter the first number");
                    numOne = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the second number");
                    numTwo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Choose what you want to calculate: 1. addition, 2. subtraction, 3. multiplikation, 4. divison");
                    string userChoice = Console.ReadLine();


                    switch (userChoice)
                    {
                        case "1":
                            result = numOne + numTwo;
                            Console.WriteLine($"The result of the addition is: {result}");
                            break;
                        case "2":
                            result = numOne - numTwo;
                            Console.WriteLine($"The result of the subtraction is: {result}");
                            break;
                        case "3":
                            result = numOne * numTwo;
                            Console.WriteLine($"The result of the multiplikation is: {result}");
                            break;
                        case "4":
                            divisonResult = numOne / (double)numTwo;
                            Console.WriteLine($"The result of the divison is: {divisonResult:F2}");
                            break;
                        default:
                            Console.WriteLine("Not a valid choice");
                            break;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("No valid number");
                }
         
                Console.WriteLine("Do you want to calculate again? y/n");
                calculateAgain = Console.ReadLine().ToLower();

            } while (calculateAgain == "y" || calculateAgain == "yes");
            
        }
    }
}
