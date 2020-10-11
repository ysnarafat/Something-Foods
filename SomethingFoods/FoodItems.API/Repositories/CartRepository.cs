using FoodItems.API.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodItems.API.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly IMongoCollection<Cart> _col;
        public CartRepository(DatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _col = database.GetCollection<Cart>(settings.CollectionName);
        }
        public List<Cart> GetAllItems()
        {
            var items = _col.Find(item => true).ToList();
            return items;
        }
        public void InsertItem(Cart cart)
        {
            _col.InsertOne(cart);
        }
    }
}
