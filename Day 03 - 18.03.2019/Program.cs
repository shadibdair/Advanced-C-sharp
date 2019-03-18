using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> StudentList = new List<Student>();
            StudentList.Add(new Student("Shadi", 98, 20));
            StudentList.Add(new Student("Naor", 90, 24));
            StudentList.Add(new Student("Ofek", 85, 23));
            StudentList.Add(new Student("Bob", 60, 24));
            StudentList.Add(new Student("Alice", 99, 30));

            Console.WriteLine("**Welcome**");

            // --------------------------------------------------------------------------
            // Way 1

            var NAMEE = from element in StudentList
                          orderby element.Name
                          select element;
            Console.WriteLine();
            Console.WriteLine("Sorted By Name: ");
            // sorted Name
            foreach (var value in NAMEE)
            {
              
                Console.WriteLine(value.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            var AGEE = from element in StudentList
                          orderby element.Age
                          select element;
            Console.WriteLine("Sorted By Age: ");
            // sorted Age
            foreach (var value in AGEE)
            {

                Console.WriteLine(value.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            var GRADEE = from element in StudentList
                          orderby element.Grade
                          select element;
            Console.WriteLine("Sorted By Grade: ");
            // sorted Grade
            foreach (var value in GRADEE)
            {

                Console.WriteLine(value.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

            // --------------------------------------------------------------------------
            // Way 2

            Console.WriteLine("Sorted By Age: ");
            StudentList.Sort((s1, s2) => s2.Age - s1.Age);
            StudentList.ForEach(s => Console.WriteLine(s.ToString()));

            Console.WriteLine("Sorted By Grade: ");
            StudentList.Sort((s1, s2) => s2.Grade - s1.Grade);
            StudentList.ForEach(s => Console.WriteLine(s.ToString()));

            Console.WriteLine("Sorted By Name: ");
            StudentList.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));
            StudentList.ForEach(s => Console.WriteLine(s.ToString()));

            // --------------------------------------------------------------------------
        }
    }
}
