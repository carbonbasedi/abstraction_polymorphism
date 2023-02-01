using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace calc_level2
{
    internal sealed class Addition : Calculation
    {
        public override int Operate(int x, int y)
        {
            int res = x + y;
            Console.WriteLine($"Addition : First number = {x} | Second number = {y} | Result = {res}");
            return res;
        }
    }
}
