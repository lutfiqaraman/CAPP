using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPP
{
    class ClassB : ClassA
    {

        public override void Print()
        {
            Console.WriteLine("I am class B");
        }

        public int CalcB()
        {
            int sum = 1 + 1;
            return sum;
        }
    }
}
