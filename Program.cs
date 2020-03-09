using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA aa = new ClassA();
            ClassB bb = new ClassB();
            ClassC cc = new ClassC();

            aa.Print();
            bb.Print();
            cc.Print();

            Console.ReadKey();
        }
    }
}
