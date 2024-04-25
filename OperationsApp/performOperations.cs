using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsApp
{
    internal class performOperations
    {
        public void performDivide()
        {
            Console.Write("Enter numerator: ");
            int numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            int res = OperationsLibrary.operations.Divide(numerator, denominator);
            Console.Write("Result = " + res);
        }

        public void performMultiply()
        {
            Console.Write("Enter First Number: ");
            int numA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int numB = Convert.ToInt32(Console.ReadLine());

            int res = OperationsLibrary.operations.Multiply(numA, numB);
            Console.Write("Result = " + res);
        }

        public void performAdd()
        {
            Console.Write("Enter First Number: ");
            int numA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int numB = Convert.ToInt32(Console.ReadLine());

            int res = OperationsLibrary.operations.Add(numA, numB);
            Console.Write("Result = " + res);
        }

        public void performSubtract()
        {
            Console.Write("Enter First Number: ");
            int numA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int numB = Convert.ToInt32(Console.ReadLine());

            int res = OperationsLibrary.operations.Subtract(numA, numB);
            Console.Write("Result = " + res);
        }

        public void performRemainder()
        {
            Console.Write("Enter First Number: ");
            int numA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int numB = Convert.ToInt32(Console.ReadLine());

            int res = OperationsLibrary.operations.Remainder(numA, numB);
            Console.Write("Result = " + res);
        }
    }
}
