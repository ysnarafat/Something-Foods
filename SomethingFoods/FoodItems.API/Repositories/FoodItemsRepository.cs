using FoodItems.API.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodItems.API.Repositories
{
    public class FoodItemsRepository : IFoodItemsRepository
    {

        private readonly IMongoCollection<FoodItem> _col;
        public FoodItemsRepository (DatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _col = database.GetCollection<FoodItem>(settings.CollectionName);
        }
        public List<FoodItem> GetAllItems()
        {
            var items = _col.Find(item => true).ToList();
            return items;
        }
        public void InsertItem(FoodItem document)
        {
            _col.InsertOne(document);
        }
    }
}
