using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewWhiteboardSamples.StringManipulation
{



    public class StringHelper
    {

        // --- Directions
        // Given a string, return a new string with the reversed
        // order of characters
        // --- Examples
        //   reverse('apple') === 'leppa'
        //   reverse('hello') === 'olleh'
        //   reverse('Greetings!') === '!sgniteerG'
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();

            Array.Reverse(arr);
            return new string(arr);
        }

        //Starting with.NET 3.5, you can use a number of extension methods that are part of the 
        //System.Linq namespace to act upon any type that implements IEnumerable<T>.
        //This includes the string type in C# (System.String), which implements IEnumerable<char>.
        public static string EasyReverse(string s)
        {

            //Uses Linq. 
            return new string(s.Reverse().ToArray());

        }


        public static string ReverseCommaDelimittedString(string s)
        {
            string commaDelimmeted = "1,2,3,4,5,6";
            var arr = commaDelimmeted.Split(",").Reverse();
            //Reverse the number by treating as a string
            var test = string.Join(",", arr);

            return test;
        }
        public static string ReverstringLoop(string str)
        {
            char[] chars = str.ToCharArray();

            char[] results = new char[chars.Length];

          

            for(int i = 0, j = str.Length -1; i < str.Length; i++, j--)
            {
                results[i] = chars[j];
            }

            return new string(results);

        }

        public static string ReverstringLoopForEachLoop(string str)
        {
            string reversed = string.Empty;

            foreach (char c in str)
            {
                reversed = c + reversed;
            }

            return new string(reversed);

        }


    }
}
