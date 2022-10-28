using System;
using System.Collections.Generic;
using System.Text;

namespace Tech_Assessment_PayEvo
{
    public class Q2
    {
        public static void findPairMatchTarget(int[]arr,int target)
        {
            int temp = 0;
            int second = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int first = arr[i];
                temp = target - first;
                if (temp > 0 && first != temp)
                {
                    second = Array.Find(arr, a => a == temp);
                    if (second != 0)
                    {
                        Console.WriteLine("Match Found : [" + Array.IndexOf(arr, first) + "," + Array.IndexOf(arr, second) + "]");
                        break;
                    }

                }
            }
        }
    }
}
