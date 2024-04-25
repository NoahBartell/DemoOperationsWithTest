using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsApp
{
    internal class operationsApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIVISION");
            performOperations operations1 = new performOperations();
            operations1.performDivide();
            Console.ReadLine();

            Console.WriteLine("\nMULTIPLICATION");
            operations1.performMultiply();
            Console.ReadLine();

            Console.WriteLine("\nADDITION");
            operations1.performAdd();
            Console.ReadLine();

            Console.WriteLine("\nSUBTRACTION");
            operations1.performSubtract();
            Console.ReadLine();

            Console.WriteLine("\nREMAINDER");
            operations1.performRemainder();
            Console.ReadLine();
        }
    }
}
