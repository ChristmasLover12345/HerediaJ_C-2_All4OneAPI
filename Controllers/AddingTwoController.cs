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
    public class AddingTwoController : ControllerBase
    {
        
        private readonly AddingTwoService _addingTwoService;
        public AddingTwoController(AddingTwoService addingTwoService)
        {
            _addingTwoService = addingTwoService;
        }

        [HttpGet]
        [Route("AddTwo/{num1}/{num2}")]
        public string AddTwo(string num1, string num2)
        {
            return _addingTwoService.AddTwo(num1, num2);
        }

    }
}