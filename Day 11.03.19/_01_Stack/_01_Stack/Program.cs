using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // FIFO - First in First out
            Stack<string> shirtsStack = new Stack<string>();

            // add a new element to the end of the Stack
            shirtsStack.Push("shirt1");
            shirtsStack.Push("shirt2");
            shirtsStack.Push("shirt3");

            Console.WriteLine(shirtsStack.Count); // --> 3

            // Remove and return the object at the top of the stack
            string topOfStack = shirtsStack.Pop();
            Console.WriteLine(topOfStack + " " + shirtsStack.Count); // --> shirt3 2

            // Remove the object at the top of the Stack without removing it
            string peekNext = shirtsStack.Peek();
            Console.WriteLine(peekNext + " " + shirtsStack.Count); // --> shirt 2
        }
    }
}
