using System;
using System.Collections.Generic;
using System.Text;

namespace Tech_Assessment_PayEvo
{
    public class Q1
    {
        public static int lengthOfLongestSubstring(string s)
        {
            int length = 0;
            int i = 0;
            int j = 0;
            HashSet<char> hset = new HashSet<char>();
            while (i<s.Length)
            {
                if (!hset.Contains(s[i]))
                {
                    hset.Add(s[i]);
                    length = Math.Max(length, hset.Count);
                    i++;
                }
                else
                {
                    hset.Remove(s[j]);
                    j++;
                   
                }
            }
            return length;

        }
    }
}
