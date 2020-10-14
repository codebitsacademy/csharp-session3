using System;

namespace CalculatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int operation;

            Console.WriteLine("Console Calculator\nTo add enter 1\nTo add enter 1\nTo subtract enter 2\nTo multiply enter 3\nTo divide enter 4\nTo get remainder enter 5\n");

            Console.Write("Please enter first number: ");
            calculator.FirstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter second number: ");
            calculator.SecondNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operation to perform: ");
            operation = Convert.ToInt32(Console.ReadLine());

            if (operation == 1)
            {
                Console.WriteLine($"Calling Add method gives - {calculator.Add()}");
            } else if( operation == 2){
                Console.WriteLine($"Calling Sub method gives - {calculator.Sub()}");
            } else if( operation == 3){
                Console.WriteLine($"Calling Multiply method gives - {calculator.Multiply()}");
            } else if( operation == 4){
                Console.WriteLine($"Calling Divide method gives - {calculator.Divide()}");
            } else if( operation == 5){
                Console.WriteLine($"Calling Modulus method gives - {calculator.Modulus()}");
            } else {
                Console.WriteLine("Invalid operation entered!");
            }
            
            
            
            
        }
    }
}
