using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            //code for palindrome
            Console.Write("Enter a : ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine($"'{input}' is a palindrome.");
            }
            else
            {
                Console.WriteLine($"'{input}' is not a palindrome.");
            }
            Console.ReadLine();
        }

        static bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}
