using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_types_floatpointtypes
{
    class Program
    {
        static void Main(string[] args)
        {
            float flmin = float.MinValue;
            float flmax = float.MaxValue;
            Console.WriteLine("min value= {0} max value= {1}", flmin, flmax);


            float flvar = 1f / 3;
            double dlvar = 1D / 3;
            decimal dcvar = 1M / 3;
            Console.WriteLine("float value ={0}\n double value ={1}\n decimal value ={2}", flvar, dlvar, dcvar);
            Console.ReadKey();
        }
    }
}
