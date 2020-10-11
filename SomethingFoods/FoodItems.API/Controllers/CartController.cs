using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodItems.API.Models;
using FoodItems.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoodItems.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ILogger<CartController> _logger;
        private readonly ICartRepository _cartRepository;

        public CartController(ILogger<CartController> logger, ICartRepository cartRepository)
        {
            _logger = logger;
            _cartRepository = cartRepository;
        }

        [HttpGet]
        public ActionResult<List<Cart>> Get()
        {
            return _cartRepository.GetAllItems();
        }


        [HttpPost]
        public ActionResult Insert([FromBody] Cart item)
        {
            _cartRepository.InsertItem(item);
            return Ok();
        }
    }
}
