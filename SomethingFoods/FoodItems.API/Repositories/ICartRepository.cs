using FoodItems.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodItems.API.Repositories
{
    public interface ICartRepository
    {
        public List<Cart> GetAllItems();
        public void InsertItem(Cart cart);
    }
}
