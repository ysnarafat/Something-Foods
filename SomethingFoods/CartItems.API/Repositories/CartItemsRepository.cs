using CartItems.API.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartItems.API.Repositories
{
    public class CartItemsRepository : ICartItemsRepository
    {
        private readonly IMongoCollection<CartItem> _col;
        public CartItemsRepository(DatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _col = database.GetCollection<CartItem>(settings.CollectionName);
        }
        public List<CartItem> GetAllItems()
        {
            var items = _col.Find(item => true).ToList();
            return items;
        }
        public void InsertItem(CartItem cart)
        {
            _col.InsertOne(cart);
        }
    }
}
