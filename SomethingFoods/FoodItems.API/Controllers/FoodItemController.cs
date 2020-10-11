using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodItems.API.Models;
using FoodItems.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoodItems.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodItemController : ControllerBase
    {

        private readonly ILogger<FoodItemController> _logger;
        private readonly IFoodItemsRepository _foodItemsRepository;

        public FoodItemController(ILogger<FoodItemController> logger,IFoodItemsRepository foodItemsRepository)
        {
            _logger = logger;
            _foodItemsRepository = foodItemsRepository;
        }

        [HttpGet]
        public ActionResult<List<FoodItem>> Get()
        {
            return _foodItemsRepository.GetAllItems();
        }

        // GET api/<FoodItemController>/110ec627-2f05-4a7e-9a95-7a91e8005da8
        [HttpGet("{id}")]
        public ActionResult<FoodItem> Get(Guid id)
        {
            var catalogItem = _foodItemsRepository.GetFoodItem(id);
            return Ok(catalogItem);
        }

        [HttpPost]
        public ActionResult Post([FromBody] FoodItem foodItem)
        {
            _foodItemsRepository.InsertItem(foodItem);
            return Ok();
        }

        // PUT api/<FoodItemController>
        [HttpPut]
        public ActionResult Put([FromBody] FoodItem foodItem)
        {
            if (foodItem != null)
            {
                _foodItemsRepository.UpdateFoodItem(foodItem);
                return new OkResult();
            }
            return new NoContentResult();
        }

        // DELETE api/<FoodItemController>/110ec627-2f05-4a7e-9a95-7a91e8005da8
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _foodItemsRepository.DeleteFoodItem(id);
            return new OkResult();
        }

    }
}
