using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewWhiteboardSamples.StringManipulation
{
    // --- Directions
    // Given a string, return the character that is most
    // commonly used in the string.
    // --- Examples
    // maxChar("abcccccccd") === "c"
    // maxChar("apple 1231111") === "1"
    //Anagram example: Does sting A have the same characters as string B
    public static class MaxCharacters
    {
        public static void GetMaxCharacterUsingLinq(string s)
        {
            //This will give a collection with letters that have the same count
            var res = s.GroupBy(p => p).Select(p => new { Count = p.Count(), Char = p.Key }).GroupBy(p => p.Count, p => p.Char).OrderByDescending(p => p.Key).First();


            //this will just return the highest count character.
            // return s.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key.ToString();

            foreach (var r in res)
            {
                Console.WriteLine("{0}: {1}", res.Key, r);
            }
           // return "s";
        }

        public static string GetMaxCharacterUsingForLoop(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            int max = 0;

            foreach (char c in "abbbbccccd")
            {
                int i;
                dict.TryGetValue(c, out i);
                i++;
                if (i > max)
                {
                    max = i;
                }
                dict[c] = i;
            }

            foreach (KeyValuePair<char, int> chars in dict)
            {
                if (chars.Value == max)
                {
                    Console.WriteLine("{0}: {1}", chars.Key, chars.Value);
                }
            }

            return "a";
        }
    }
}
