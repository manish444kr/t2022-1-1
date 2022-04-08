using System;

namespace Tandemloop_Manish
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator obj = new Calculator(args[0], args[1], args[2]);
            obj.CalculateMethod();
            Console.ReadLine();
        }
    }
}
