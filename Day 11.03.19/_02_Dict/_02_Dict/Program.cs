using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary can contain item with an unique Key 
            // its like hashMap in java
            Dictionary<string, double> studentGrade = new Dictionary<string, double>();

            // adds the specified kye and value to the dictionary
            studentGrade.Add("Bob", 90.5);
            studentGrade.Add("Alice", 100);

            Console.WriteLine($"Bob got: {studentGrade["Bob"]}"); // Bob 90.5
            Console.WriteLine($"Alice got: {studentGrade["Alice"]}"); // Alice 100
            
            var s = studentGrade.Keys;

            // KeyValuePair also you can use Var
            foreach (KeyValuePair<string,double> item in studentGrade)
            {
                Console.WriteLine(item.Key + " " + item.Value); // Bob 90.5
                                                                // Alice 100
            }

            // ContainsKey Determines whether we have already this Key in the dictionary
            if (!studentGrade.ContainsKey("Alice"))
            {
                studentGrade.Add("Alice", 100);
            }
            else
            {
                Console.WriteLine("Alice already exists");
            }
        }
    }
}
