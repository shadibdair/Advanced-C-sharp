using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Dictionary_of_Objects
{
    class Food
    {
        public decimal Price { get; set; }
        public bool IsVeg { get; set; }

        public string GetDesc()
        {
            return $"Pizza:{Price} , IsVeg:{IsVeg} ";
        }
    }
}
