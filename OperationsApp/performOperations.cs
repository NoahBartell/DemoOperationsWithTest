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
    }
}
