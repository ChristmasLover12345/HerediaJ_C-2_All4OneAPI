using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HerediaJ_C_2_All4OneAPI.Models;

namespace HerediaJ_C_2_All4OneAPI.Services
{
    public class Magic8BallService
    {
        
        Random rng = new Random();

        // Did this one with module but it was overcomplicates and gave me a bunch of errors so I just did it normal
        public string Magic8Ball(string userQuestion)
        {
            string answer = ""; 
            bool numbersOnly = true;
            char[] charArray = userQuestion.ToCharArray();


            // Cheking if the answer provided is only numbers
            for (int i = 0; i < charArray.Length; i++)
            {
                bool validation = int.TryParse(charArray[i].ToString(), out int convertedNum);

                if (validation != true)
                {
                    numbersOnly = false;
                }
               
                
            }



            if(numbersOnly == true)
            {
                return "I dont speak robot";
            }
            else
            {
            switch (rng.Next(9))
            {

                case 1:
                    answer = $"Your question was: {userQuestion} \nYour answer: Perchance.";
                break;
                case 2:
                    answer = $"Your question was: {userQuestion} \nYour answer: Ask again. ";
                break;
                 case 3:
                    answer = $"Your question was: {userQuestion} \nYour answer: Sources say: True!";
                break;
                case 4:
                    answer = $"Your question was: {userQuestion} \nYour answer: Probabilty of succes: 100%!";
                break;
                 case 5:
                    answer = $"Your question was: {userQuestion} \nYour answer: Not gonna happen bro";
                break;
                case 6:
                    answer = $"Your question was: {userQuestion} \nYour answer: Not likely";
                break;
                 case 7:
                    answer = $"Your question was: {userQuestion} \nYour answer: ...What? sorry I wasn't paying attention";
                break;
                case 8:
                    answer = $"Your question was: {userQuestion} \nYour answer: Just give up";
                break;

            }
            }

            return answer;

        }
}
}