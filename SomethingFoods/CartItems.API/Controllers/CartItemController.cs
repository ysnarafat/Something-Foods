using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartItems.API.Models;
using CartItems.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CartItems.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartItemController : ControllerBase
    {
        private readonly ILogger<CartItemController> _logger;
        private readonly ICartItemsRepository _cartItemRepository;

        public CartItemController(ILogger<CartItemController> logger, ICartItemsRepository cartItemRepository)
        {
            _logger = logger;
            _cartItemRepository = cartItemRepository;
        }

        [HttpGet]
        public ActionResult<List<CartItem>> Get()
        {
            return _cartItemRepository.GetAllItems();
        }


        [HttpPost]
        public ActionResult Insert([FromBody] CartItem item)
        {
            _cartItemRepository.InsertItem(item);
            return Ok();
        }
    }
}
