using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace InterviewWhiteboardSamples.StringManipulation
{
    // --- Directions
    // Check to see if two provided strings are anagrams of eachother.
    // One string is an anagram of another if it uses the same characters
    // in the same quantity. Only consider characters, not spaces
    // or punctuation.  Consider capital letters to be the same as lower case
    // --- Examples
    //   anagrams('rail safety', 'fairy tales') --> True
    //   anagrams('RAIL! SAFETY!', 'fairy tales') --> True
    //   anagrams('Hi there', 'Bye there') --> False

    public static class Anagrams
    {
        public static void MyAnagram(string string1, string string2)
        {
            char[] ch1 = string1.ToLower().Trim().Replace(@"/[^\w]/g", "").ToCharArray();
            char[] ch2 = string2.ToLower().Trim().Replace(@"/[^\w] / g", "").ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            string my_String = Regex.Replace(val1, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
            string my_String2 = Regex.Replace(val2, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
            //if (my_String == vamy_String2l2)
            //{
            //    Console.Write("Both string are Anagrams");
            //}
            //else
            //{
            //    Console.Write("Both string are NOT Anagrams");
            //}


        }
    }
}
