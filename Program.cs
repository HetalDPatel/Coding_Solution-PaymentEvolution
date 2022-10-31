using System;

namespace Tech_Assessment_PayEvo
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Given a string s, find the length of the longest substring without repeating characters.
            Console.WriteLine("****** Question#1 ******");
            Q1Method();

            //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
            Console.WriteLine("****** Question#2 ******");
            //Q2Method();

            //Given an integer x, return true if x is palindrome integer.
            Console.WriteLine("****** Question#3 ******");
            //Q3Method();

        }

        public static void Q1Method()
        {
            Console.WriteLine("Enter the String to get the longest substring without repeating characters :");
            string str = Console.ReadLine();
            Console.WriteLine("Length is: "+ Q1.lengthOfLongestSubstring(str));

        }

        public static void Q2Method()
        {
            int target = 101;
            int[] arr = { 1, 4, 6, 7,50,51 };
            Q2.findPairMatchTarget(arr,target);
        }


        public static void Q3Method()
        {             
            long number = 0;
            try
            {
                Console.WriteLine("Enter any Number to check its a Palindrome or not!");
                number = Convert.ToInt64(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error info:" + ex.Message);
                Console.Write("Enter integer number:");
                number = Convert.ToInt64(Console.ReadLine());
            }
            Console.WriteLine(Q3.isNumPalindrome(number));

        }
    }
}
