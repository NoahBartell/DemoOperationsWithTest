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
        }
    }
}
