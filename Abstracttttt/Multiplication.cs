using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc_level2
{
    internal sealed class Multiplication : Calculation
    {
        public override int Operate(int x, int y)
        {
            int res = x * y;
            Console.WriteLine($"Multiplication : First number = {x} | Second number = {y} | Result = {res}");
            return res;
        }
    }
}
