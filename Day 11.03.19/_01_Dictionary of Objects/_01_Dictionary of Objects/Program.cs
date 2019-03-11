using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Dictionary_of_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Food> foodStack = new Dictionary<string, Food>();
            foodStack.Add("Chips", new Food { Price = 17, IsVeg = false });
            foodStack.Add("Salad", new Food { Price = 50, IsVeg = true });
            foodStack.Add("Pizza", new Food { Price = 14, IsVeg = false });

            foreach (KeyValuePair<string,Food> item in foodStack)
            {
                Console.WriteLine($"{item.Key} - {item.Value.GetDesc()}");
            }

            string selectedFood = "Chips";
            Console.WriteLine(foodStack[selectedFood].GetDesc()); //Pizza:17 , IsVeg:False
        }
    }
}
