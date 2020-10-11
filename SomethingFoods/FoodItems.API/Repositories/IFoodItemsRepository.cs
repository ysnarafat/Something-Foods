using FoodItems.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodItems.API.Repositories
{
    public interface IFoodItemsRepository
    {
        public List<FoodItem> GetAllItems();
        public void InsertItem(FoodItem foodItem);

        public FoodItem GetFoodItem(Guid id);

        public void UpdateFoodItem(FoodItem foodItem);

        public void DeleteFoodItem(Guid id);
    }
}
