using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             (Dynamic):
             Store any type of value in the dynamic data type variable created using 
             dynamic keyword. Type checking for these types of variables
             takes place at run-time. 
             Dynamic are dynamically typed variables.

            The dynamic types are similar to object types except that 
            type checking for object type variables takes place at compile time,
            whereas that for the dynamic type variables takes place at runtime.
             */

            /*
             (Var):
             The "var" keyword initializes variables with var support. 
             Just assign whatever value you want for the variable,
             integer, string, float, etc. It is a statically typed variable.
             */


            var x = "string1"; // early bounded
            int len = x.Length;
            Console.WriteLine(len); // 7

            dynamic y = "string1"; // late bounded
            int len1 = y.length; // RuntimeBinder.RuntimeBinderException: 'string'




            
        }
    }
}
