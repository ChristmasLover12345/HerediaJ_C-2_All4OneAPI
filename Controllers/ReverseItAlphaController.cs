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
    public class ReverseItAlphaController : ControllerBase
    {
        

        private readonly ReverseItAlphaService _reverseItAplhaService;

       public ReverseItAlphaController(ReverseItAlphaService reverseItAlphaService)
       {
        _reverseItAplhaService = reverseItAlphaService;
       }


        [HttpGet]
        [Route("ReverseAlpha/{word}")]
        public string ReverseAlpha(string word)
        {
            return _reverseItAplhaService.ReverseAlpha(word);
        }


    }
}