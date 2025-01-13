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
    public class MadLibController : ControllerBase
    {
        
         private readonly MadLibServices _madLibServices;

        public MadLibController(MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }

        [HttpGet]
        [Route("MadLib/{Object}/{holiday}/{place}/{relative}/{animal}/{food}/{color}/{pluralNoun}/{adjective}/{weather}")]
        public string MadLib(string Object, string holiday, string place, string relative, string animal, string food, string color, string pluralNoun, string adjective, string weather )
        {

            return _madLibServices.MadLib( Object, holiday, place, relative, animal, food, color, pluralNoun, adjective, weather);

        }
        

    }
}