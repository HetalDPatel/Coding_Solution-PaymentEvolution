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
            HashSet<char> hset = new HashSet<char>();
            foreach (char c in s)
            {
                if (!hset.Contains(c))
                {
                    hset.Add(c);
                    length = Math.Max(length, hset.Count);
                }
                else
                {
                    hset.Remove(s[i]);
                    i++;
                }
            }
            return length;

        }
    }
}
