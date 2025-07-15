using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class MathShortcut
    {//in math, x is a variable. dont necessarily have to be descriptive
        public static double Add(double x, double y)
        {
            //Console.WriteLine($"The value of {x} + {y} = {x+y}");
            double output = x + y;
            return output;
        }

        //defining at the method call, not at the method itself
        public static void AddAll(double[] values)
        {
            double result = 0;
            values.Sum(); //do samething, sum of set. Linq
            foreach(double value in values)
            {
                result += value;
            }

            Console.WriteLine($"Total is {result}");
        }
    }
} 
