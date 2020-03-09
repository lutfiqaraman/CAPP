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
            ClassD d = new ClassD();

            d.PloyPrint(a);
            d.PloyPrint(b);
            d.PloyPrint(c);

            Console.ReadKey();
        }
    }
}
