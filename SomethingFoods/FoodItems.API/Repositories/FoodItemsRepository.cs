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

        public void DeleteFoodItem(Guid id)
        {
            _col.DeleteOne<FoodItem>(item => item.Id == id);
        }

        public List<FoodItem> GetAllItems()
        {
            var items = _col.Find(item => true).ToList();
            return items;
        }

        public FoodItem GetFoodItem(Guid id)
        {
            var item = _col.Find<FoodItem>(item => item.Id == id).FirstOrDefault();
            return item;
        }

        public void InsertItem(FoodItem document)
        {
            _col.InsertOne(document);
        }

        public void UpdateFoodItem(FoodItem foodItem)
        {
            _col.UpdateOne<FoodItem>(item => item.Id == foodItem.Id, Builders<FoodItem>.Update
                .Set(c => c.Name, foodItem.Name)
                .Set(c => c.Price, foodItem.Price)
                );
            //.Set(c => c.Description, foodItem.Description)
        }
    }
}
