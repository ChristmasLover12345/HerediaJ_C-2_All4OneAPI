using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerediaJ_C_2_All4OneAPI.Services
{
    public class OddOrEvenService
    {
        public string OddOrEven(string number)
        {

            bool validation = int.TryParse(number, out int convertedNum);

            if (validation == true)
            {

                if (convertedNum % 2 == 0)
                {
                    return $"{number} is Even";
                }
                else
                {
                    return $"{number} is Odd";
                }

            }
            else if (number.Trim() == "")
            {
                return "Please Type Something bruuuhhhhhhh";
            }
            else
            {
                return "Numbers only";
            }

        }
    }
}