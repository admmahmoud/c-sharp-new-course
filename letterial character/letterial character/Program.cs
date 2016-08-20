using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letterial_character
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar = -100;
            uint myuvar = 1000u;
            float myfvar = 1.5f;
            double mydvar = 100.5d;
            decimal mydcvar = 100.5m;
            Console.WriteLine("{0} {1}", myvar, myuvar);
            Console.WriteLine($"{myfvar} {mydvar} {mydcvar}");
            Console.ReadKey();
        }
    }
}
