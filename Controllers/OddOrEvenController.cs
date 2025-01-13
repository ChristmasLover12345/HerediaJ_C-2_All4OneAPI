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
    public class OddOrEvenController : ControllerBase
    {
        
        private readonly OddOrEvenService _oddOrEvenService;

        public OddOrEvenController(OddOrEvenService oddOrEvenService)
        {
            _oddOrEvenService = oddOrEvenService;
        }

        [HttpGet]
        [Route("/{number}")]

        public string OddOrEven(string number)
        {
            return _oddOrEvenService.OddOrEven(number);
        }

    }
}