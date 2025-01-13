using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerediaJ_C_2_All4OneAPI.Services
{
    public class ReverseItAlphaService
    {
         public string ReverseAlpha(string word)
        {

             char[] charArray = word.ToCharArray();
             Array.Reverse(charArray);
             string reversedWrod = new string(charArray);
             return $"You entered {word}, The reversed is {reversedWrod}";
        }
        
    }
}