using System;
using System.Collections.Generic;


namespace Program_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> obj = new Dictionary<int, int>();
            List<int> list = new List<int>();
            foreach (string i in args)
            {
                list.Add(Convert.ToInt32(i));

            }

            List<int> num = new List<int>();
            for (int k = 1; k < 10; k ++)
            {
                num.Add(k);
            }

            
            foreach (int i in num)
            {
                obj.Add(i, CountOfDivisor(list, i));

            }
            int CountOfDivisor(List<int> l, int div)
            {
                int count = 0;
                foreach (int i in l)
                {
                    if (i % div == 0)
                    {
                        count++;
                    }

                }
                return count;
            }

            Console.WriteLine("Key " + " : " + "Value");
            Console.WriteLine("------------------------");
            foreach (int i in obj.Keys)
            {
                Console.WriteLine(i+"   :   " + obj[i]);

            }
            Console.ReadLine();

        }
   
    }
}
