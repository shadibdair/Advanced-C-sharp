using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Queue<string>> x = new Dictionary<string, Queue<string>>();
            x.Add("Bank", new Queue<string>());
            x.Add("Change", new Queue<string>());
            x.Add("Post", new Queue<string>());
            int i = 0; 
            while (i<10)
            {
                Console.Write("name:");
                string name = Console.ReadLine();
                Console.Write("requiered service(Bank/Change/Post):");
                string queue = Console.ReadLine();

                if (x.ContainsKey(queue))
                    x[queue].Enqueue(name);
              
                i++;
            }


            int emptyQueueCounter = 0;
            while ( emptyQueueCounter <  x.Count)
            {
                emptyQueueCounter = 0;
                foreach (KeyValuePair<string, Queue<string>> item in x)
                {
                    
                    if (item.Value.Count > 0)
                    {
                        Console.WriteLine($"queue {item.Key} is waiting for {item.Value.Dequeue()}");
                    }
                    else
                    {
                        emptyQueueCounter++;
                    }
                    Console.WriteLine("----------------------");

                }
            }
            


        }
    }
}
