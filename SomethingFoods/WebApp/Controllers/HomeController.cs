using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FoodItems.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var model = new FoodItemModel();
            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = await httpClient.GetAsync("https://localhost:44329/api/fooditem"))
            //    {
            //        string apiResponse = await response.Content.ReadAsStringAsync();
            //        model.items = JsonConvert.DeserializeObject<List<FoodItem>>(apiResponse);
            //    }
            //}
            model.items = new List<FoodItem>
            {
                new FoodItem
                {
                    Name = "Rice",
                    Price = 250
                },
                new FoodItem
                {
                    Name = "Rice",
                    Price = 300
                },
                new FoodItem
                {
                    Name = "Rice",
                    Price = 400
                },
                new FoodItem
                {
                    Name = "Rice",
                    Price = 500
                },
                new FoodItem
                {
                    Name = "Rice",
                    Price = 250
                },
                new FoodItem
                {
                    Name = "Rice",
                    Price = 300
                },
                new FoodItem
                {
                    Name = "Rice",
                    Price = 400
                },
                new FoodItem
                {
                    Name = "Rice",
                    Price = 500
                },
                new FoodItem
                {
                    Name = "Rice",
                    Price = 300
                },
                new FoodItem
                {
                    Name = "Rice",
                    Price = 400
                },
                new FoodItem
                {
                    Name = "Rice",
                    Price = 500
                }
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
