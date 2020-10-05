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
        public void InsertItem(FoodItem document);
    }
}
