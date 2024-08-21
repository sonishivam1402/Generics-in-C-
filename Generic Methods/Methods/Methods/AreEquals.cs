using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Calc
    {
        public static bool areEquals<T>(T a, T b)
        {
            return a.Equals(b);
        }

        /*public static void Main()
        {
            bool equal = Calc.areEquals<int>(1, 2);
            Console.WriteLine(equal);

            bool equal1 = Calc.areEquals<string>("a", "a");
            Console.WriteLine(equal1);
        }*/

    }
    
}
