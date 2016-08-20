using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_types_char
{
    class Program
    {
        static void Main(string[] args)
        {
            int charmin = char.MinValue;
            int charmax = char.MaxValue;
            char myvar = 'H';
            int myvarvalue = 'H';
            char myvarvalue2 = Convert.ToChar(72);
           
            Console.WriteLine("  min char = {0} max char  = {1} my character = {2} my variable number is {3}  my conversion value is {4}" , charmin, charmax, myvar,myvarvalue,myvarvalue2);


            string mystring = "this is my variable";
            Console.WriteLine("my string is  {0}", mystring);

            bool mybool = true;
            Console.WriteLine("my boolean value is {0}", mybool);
            Console.ReadKey();
        }
    }
}
