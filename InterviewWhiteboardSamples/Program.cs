using InterviewWhiteboardSamples.StringManipulation;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewWhiteboardSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseString();
        }

        public static void ReverseString() {

            //--Calls the StringHelper class to Reverse a string. Look in StringHelper Class
            // example : Console.WriteLine(StringManipulation.StringHelper.ReverstringLoopForEachLoop("framework"));


            //int a = 10;
            //int b = 20;
            //Swap2Numbers.Swap(ref a, ref b);
            //Console.WriteLine("a is now: " + a + "b is now : " + b);
            //Console.Read();

            //--Call palindrome class and return true or false if a words equals the same forward as backwards
            //Example : Console.WriteLine(StringManipulation.Palindrome.IsPalindromeReversingTheString(""));

            // --Call ReverseInt class andGiven an integer, return an integer that is the reverse
            // Console.WriteLine(ReverseInt.ReverseInt1(-29));

            //Given a string, return the character that is most commonly used in the string.
            Console.WriteLine(MaxCharacters.GetMaxCharacterUsingLinq("HelloH TherooOe!"));


            //Write a program that console logs the numbers from 1 to n. But for multiples of three print
            //FizzBuzz.DoFizzBuzz();

            //Given an array and chunk size, divide the array into many subarrays
            // where each subarray is of length size
            // var test = Chunk.Split(new string[]{ "1", "2", "3", "4", "5", "6", "7"}, 2);


            //Anagrams = Check to see if two provided strings are anagrams of eachother
            //Anagrams.MyAnagram("heater!", "reheat");



        }
    }
}
