using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodItems.API.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public IList<FoodItem> FoodItems { get; set; }
        public int TotalItems { get; set; }
        public int TotalCost { get; set; }
        public Cart()
        {
            FoodItems = new List<FoodItem>();
        }
    }
}
