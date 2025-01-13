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
    public class AskingQuestionsController : ControllerBase
    {
        
        private readonly AskingQuestionsService _askingQuestionsService;
        public AskingQuestionsController(AskingQuestionsService askingQuestionsService)
        {
            _askingQuestionsService = askingQuestionsService;
        }

        [HttpGet]
        [Route("AskingYourName/{userName}")]
        public string YourName(string userName)
        {
            return _askingQuestionsService.YourName(userName);
        }

    }
}