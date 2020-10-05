using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodItems.API.Models
{
    public class FoodItem
    {
        //public static string DocumentName = "FoodItems";
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

    }
}
