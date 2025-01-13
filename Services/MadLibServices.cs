using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerediaJ_C_2_All4OneAPI.Services
{
    public class MadLibServices
    {
        

        public string MadLib(string Object, string holiday, string place, string relative, string animal, string food, string color, string pluralNoun, string adjective, string weather )
        {
            if (Object.Trim() == "" || holiday.Trim() == "" || place.Trim() == "" || relative.Trim() == "" || animal.Trim() == "" || food.Trim()== "" || color.Trim() == "" || pluralNoun.Trim() == "" || adjective.Trim() == "" || weather.Trim() == "")
            {
                return "Please Fill up all of the required spaces please";
            }
            else
            {
                return $"There was a {Object} whose favorite holiday was {holiday} and it lived at {place} with it's {relative} and their {animal} who liked to eat {food}.\nAt night they put on their {color} Pajamas to cuddle with their {pluralNoun} in their {adjective} beds. They need their rest since tomorrow is gonna be a {weather} day";
            }
        }

    }
}