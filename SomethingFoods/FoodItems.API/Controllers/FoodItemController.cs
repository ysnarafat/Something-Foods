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


        [HttpPost]
        public ActionResult Insert([FromBody] FoodItem item)
        {
            _foodItemsRepository.InsertItem(item);
            return Ok();
        }
    }
}
