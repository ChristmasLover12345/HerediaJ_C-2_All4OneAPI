using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerediaJ_C_2_All4OneAPI.Services
{
    public class ReverseItNumbersService
    {
        
        public string ReverseNumbers(string number)
        {
            char[] charArray = number.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {

                bool validation = int.TryParse(charArray[i].ToString(), out int convertedNum);

                if (validation == true)
                {

                }
                else
                {
                    return "Numbers only";
                }

            }

             Array.Reverse(charArray);
             string reversedWrod = new string(charArray);
             return $"You entered {number}, The reversed is {reversedWrod}";
        }


    }
}