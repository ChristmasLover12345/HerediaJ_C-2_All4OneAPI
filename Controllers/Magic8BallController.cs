using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HerediaJ_C_2_All4OneAPI.Models;
using HerediaJ_C_2_All4OneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HerediaJ_C_2_All4OneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Magic8BallController : ControllerBase
    {
        
        private readonly Magic8BallService _magic8BallService;

        public Magic8BallController(Magic8BallService magic8BallService)
        {
            _magic8BallService = magic8BallService;
        }

        [HttpGet]
        [Route("MagicBall/{userQuestion}")]

        public string Magic8Ball(string userQuestion)
        {
            return _magic8BallService.Magic8Ball(userQuestion);
        }


    }
}