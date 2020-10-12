using CartItems.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartItems.API.Repositories
{
    public interface ICartItemsRepository
    {
        public List<CartItem> GetAllItems();
        public void InsertItem(CartItem cart);
    }
}
