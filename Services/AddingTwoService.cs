using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerediaJ_C_2_All4OneAPI.Services
{
    public class AddingTwoService
    {
        
        public string AddTwo(string num1, string num2)
        {
            bool validation1 = int.TryParse(num1, out int firstNum);
            bool validation2 = int.TryParse(num2, out int secondNum);

            if (!validation1 || !validation2)
            {
                return "I need TWO(2(two)) NUMBERS to do this bro no words";
            }
            else if (num1 == "" || num2 == "")
            {
                return "you didnt even type anything bruh";
            }
            else 
            {
                return $"The sum of {firstNum} and {secondNum} is equal to {firstNum + secondNum}";
            }


        }


    }
}