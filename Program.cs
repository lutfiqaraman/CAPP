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
            ClassA a = new ClassA();
            ClassB b = new ClassB();
            ClassC c = new ClassC();

            a.Print();
            b.Print();
            c.Print();

            Console.ReadKey();
        }
    }
}
