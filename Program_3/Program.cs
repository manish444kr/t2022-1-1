using System;

namespace Program_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(args[0]);

            for (int i = 1; i <= a; i++)
            {
                if (i>1 && i!=a)
                {
                    Console.Write(",");
                }
                if(a%2==1 && i == a)
                {
                    Console.Write(",");
                }
                if(a%2==0 && i == a)
                {
                    break;
                }
                Console.Write((2 * i) - 1);

            }
            Console.ReadLine();



        }
        
    }
}
