using FoodItems.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class FoodItemModel
    {
        //public Guid Id { get; set; }
        //public string Name { get; set; }
        //public int Price { get; set; }
        public List<FoodItem> items { get; set; }
    }
}
