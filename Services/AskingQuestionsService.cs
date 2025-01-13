using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerediaJ_C_2_All4OneAPI.Services
{
    public class AskingQuestionsService
    {
        

        public string YourName(string userName)
        {

            bool validation = int.TryParse(userName, out int number);

            if (validation == true)
            {
                return "No robots allowed.";
            }
            else if (userName.Trim() == "")
            {
                return "Sorry, I didn't catch that, could you speak up?";
            }
            else
            {
            return $"Nice to meet you, {userName}!";
            }
            
        }

    }
}