### Task
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Program
    {
        public static Task<int> F2(object num)
        {
            return new Task<int>(()=>(int)num*2);
        }

        private static Task<int>F1()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            Task<int> res = F2(num);
            res.Start();
            return res;

        }

        static void Main(string[] args)
        {
            Task<Task<int>> t = new Task<Task<int>>(F1);
            t.Start();
            Console.WriteLine(t.Result.Result);
        }
    }
}
```