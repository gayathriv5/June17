using System.Threading.Channels;

namespace CalculatorFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Calc calc = new Calc();

            int x, y, result = 0;
            string oper;
            Console.Write("Value 1 : ");
            x = Int32.Parse(Console.ReadLine());

            Console.Write("Value 2 : ");
            y = Int32.Parse(Console.ReadLine());

            Console.Write("Enter Operator (+,-,*,/) : ");
            oper = Console.ReadLine();

            if (oper == "+")
            {
                result = calc.Add(x, y);
            }

            else if (oper == "-")
            {
                result = calc.Subtract(x, y);
            }
            else if (oper == "*")
            {
                result = calc.Multiply(x, y);
            }
            else if (oper == "/")
            {
                result = calc.Divide(x, y);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
            Console.WriteLine("Answer is " + result);
        }
    }
}