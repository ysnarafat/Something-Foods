﻿using System;
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
<<<<<<< HEAD
=======
            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = await httpClient.GetAsync("https://localhost:44329/api/fooditem"))
            //    {
            //        string apiResponse = await response.Content.ReadAsStringAsync();
            //        model.items = JsonConvert.DeserializeObject<List<FoodItem>>(apiResponse);
            //    }
            //}
>>>>>>> 41d53e24de40c601bfc3551ab17b95fe2d7985fe
            model.items = new List<FoodItem>
            {
                new FoodItem
                {
                    Name = "Rice",
<<<<<<< HEAD
                    Price = 300
                },
                new FoodItem
                {
                    Name = "Burger",
=======
                    Price = 250
                },
                new FoodItem
                {
                    Name = "Rice",
>>>>>>> 41d53e24de40c601bfc3551ab17b95fe2d7985fe
                    Price = 300
                },
                new FoodItem
                {
<<<<<<< HEAD
                    Name = "Chicken",
=======
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
>>>>>>> 41d53e24de40c601bfc3551ab17b95fe2d7985fe
                    Price = 300
                },
                new FoodItem
                {
<<<<<<< HEAD
                    Name = "Meat",
                    Price = 300
                },

            };
            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = await httpClient.GetAsync("https://localhost:44329/api/fooditem"))
            //    {
            //        string apiResponse = await response.Content.ReadAsStringAsync();
            //        model.items = JsonConvert.DeserializeObject<List<FoodItem>>(apiResponse);
            //    }
            //}
=======
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
>>>>>>> 41d53e24de40c601bfc3551ab17b95fe2d7985fe
            return View(model);
        }

        public IActionResult Login()
        {
            return View();
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
