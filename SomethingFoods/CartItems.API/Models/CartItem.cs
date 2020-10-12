using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartItems.API.Models
{
    public class CartItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int TotalItems { get; set; }
        public int TotalCost { get; set; }
    }
}
