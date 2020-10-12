using CartItems.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class CartItemModel
    {
        public List<CartItem> items { get; set; }
    }
}
