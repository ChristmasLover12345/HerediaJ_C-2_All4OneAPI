using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HerediaJ_C_2_All4OneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HerediaJ_C_2_All4OneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerService _restaurantPickerService;

        public RestaurantPickerController(RestaurantPickerService restaurantPickerService)
        {
            _restaurantPickerService = restaurantPickerService;
        }
        

        [HttpGet]
        [Route("RestaurantPicker/{userChoice}")]
        public string RestaurantMethod(string userChoice)
        {
            return _restaurantPickerService.RestaurantMethod(userChoice);
        }
    }
}