using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Tech_Assessment_PayEvo
{
    public class Q3
    {

        public static bool isNumPalindrome(int number)
        {
            int tempNumber = number;
            int reveresNum = 0;
            while (tempNumber != 0)
            {
                reveresNum = reveresNum * 10 + (tempNumber % 10);
                tempNumber = tempNumber / 10;
            }
            if (number != 0 && reveresNum == number)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
