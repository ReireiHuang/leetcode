using System;

namespace Leetcode
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            string a = x.ToString();
            string b = "";
            
            while ((x / 10) > 0)
            {
                b += x % 10;
                x /= 10;
            }
            b += x;

            if(b == a)
                return true;

            return false;
        }
    }
}