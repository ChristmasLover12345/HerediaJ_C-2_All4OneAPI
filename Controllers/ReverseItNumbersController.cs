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
    public class ReverseItNumbersController : ControllerBase
    {
        
        private readonly ReverseItNumbersService _reverseItNumbersService;

        public ReverseItNumbersController(ReverseItNumbersService reverseItNumbersService)
        {
            _reverseItNumbersService = reverseItNumbersService;
        }


        [HttpGet]
        [Route("ReverseNumber/{number}")]
        public string ReverseNumbers(string number)
        {
            return _reverseItNumbersService.ReverseNumbers(number);
        }


    }
}