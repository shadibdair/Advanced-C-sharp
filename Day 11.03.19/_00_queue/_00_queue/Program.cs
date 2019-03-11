using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // FIFO - First in First out
            Queue<string> superQueue = new Queue<string>();

            // add a new element to the end of the Queue
            superQueue.Enqueue("Bob");
            superQueue.Enqueue("Alice");
            superQueue.Enqueue("Shadi");

            Console.WriteLine(superQueue.Count); // --> 3

            // Remove and returns the object at the beginning of queue
            string nextInQueue = superQueue.Dequeue();
            Console.WriteLine(nextInQueue + " " + superQueue.Count); // --> Bob 2

            // Remove the object at the beginning queue without removing
            string peekNextInQueue = superQueue.Peek();
            Console.WriteLine(peekNextInQueue + " " +superQueue.Count); // --> Alice 2
        }
    }
}
