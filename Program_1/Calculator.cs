using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tandemloop_Manish
{
    class Calculator
    {
        
        public double A { get; private set; }
        public double B { get; private set; }
        public string Op { get; private set; }

        public Calculator(string firstInput,string secondInput,string operationName)
        {
            this.A = Convert.ToDouble(firstInput);
            this.B = Convert.ToDouble(secondInput);
            this.Op = operationName;

        }

        public void CalculateMethod()
        {
            try
            {
                if((this.Op).ToLower().Equals("addition"))
                {
                    Console.WriteLine(this.A + this.B);
                }
                else if ((this.Op).ToLower().Equals("subtraction"))
                {
                    Console.WriteLine( this.A - this.B);
                }
                else if ((this.Op).ToLower().Equals("multiplication"))
                {
                    Console.WriteLine(this.A * this.B);
                }
                else if ((this.Op).ToLower().Equals("division"))
                {
                    Console.WriteLine(this.A / this.B);
                }
                else
                {
                    Console.WriteLine("Invalid Operation Name");
                    
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
               
            }


        }
    }
}
