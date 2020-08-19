using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewWhiteboardSamples.StringManipulation
{
    // --- Directions
    // Given a string, return true if the string is a palindrome
    // or false if it is not.  Palindromes are strings that
    // form the same word if it is reversed. *Do* include spaces
    // and punctuation in determining if the string is a palindrome.
    // --- Examples:
    //   palindrome("abba") === true
    //   palindrome("abcdefg") === false

    public class Palindrome
    {
        public static bool IsPalindromeUsingLinq(string str)
        {
            return str.SequenceEqual(str.Reverse());
        }

        public static bool IsPalindromeUsingWhileLoop(string value)
        {

            for (int i = 0; i < value.Length / 2; i++)
            {
                if (value[i] != value[value.Length - i - 1])
                    return false;
            }
            return true;

         }


        public static bool IsPalindromeReversingTheString(string value)
        {

            //string backwards = new string(value.Reverse().ToArray());

            var reversedString = string.Empty;

            if (string.IsNullOrEmpty(value) || value.Length % 2 != 0)
                return false;

            foreach (char c in value)
            {
                reversedString = c + reversedString;
            }

            //using ternary return true or false 
            return reversedString.ToLower() == value.ToLower() ? true : false;

        }
    }
}
