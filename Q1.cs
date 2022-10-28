using System;
using System.Collections.Generic;
using System.Text;

namespace Tech_Assessment_PayEvo
{
    public class Q1
    {
        public static int lengthOfLongestSubstring(string str)
        {
            string newString="";
            foreach(char c in str)
            {                
                if (!newString.Contains(c))
                {
                    newString = newString + c;                  
                }                
            }
            return newString.Length;

        }
    }
}
