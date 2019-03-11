using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void printlist(List<string> myList)
        {
            Console.WriteLine("Capacity: " + myList.Capacity);
            foreach (string item in myList)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<string> myCart = new List<string>();
            // Console.WriteLine(myCart.Capacity); // capacity תכולה מה 
            printlist(myCart);
            myCart.Add("book1");
            myCart.Add("book2");
            printlist(myCart);
            myCart.AddRange(new string[] { "book3" , "book4"});
           // myCart.Add("book4");
            printlist(myCart);
            //myCart.Add("book5");
            //myCart.Add("book6");
            //printlist(myCart);

            //---------------------------------------
            myCart.Insert(2, "book5");
            printlist(myCart);
            //---------------------------------------
            myCart.InsertRange(0, new string[] { "book6", "book7" }); // add in index 0 book6 book7
            printlist(myCart);
            //---------------------------------------
            myCart.Remove("book1"); // remove book1
            printlist(myCart);
            //---------------------------------------
            myCart.RemoveAt(0); // remove where index 0
            printlist(myCart);
            //---------------------------------------
            myCart.RemoveRange(1,3); // remove all thing between index 1 until index 3
            printlist(myCart);
            //---------------------------------------
            myCart.Reverse(); // reverse
            printlist(myCart);
        }
    }
}
