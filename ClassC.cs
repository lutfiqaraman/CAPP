using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPP
{
    class ClassC : ClassA
    {
        public override void Print()
        {
            Console.WriteLine("I am class C");
        }

        public int CalcC()
        {
            int sum = 1 - 1;
            return sum;
        }
    }
}
