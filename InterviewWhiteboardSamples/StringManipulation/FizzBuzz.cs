using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewWhiteboardSamples.StringManipulation
{
    // --- Directions
    // Write a program that console logs the numbers
    // from 1 to n. But for multiples of three print
    // “fizz” instead of the number and for the multiples
    // of five print “buzz”. For numbers which are multiples
    // of both three and five print “fizzbuzz”.
    // --- Example
    //   fizzBuzz(5);
    //   1
    //   2
    //   fizz
    //   4
    //   buzz
    public static  class FizzBuzz
    {
        public static void DoFizzBuzz()
        {
            for(int i = 1; i <=100; i++)
            {
                bool isFizz = i % 3 == 0 ?  true: false;
                bool isBuzz = i % 5 == 0 ? true : false;

                //need to check for fizz and buzz because if you put fizz or buzz at the top it will show true, go in the 
                //if statement and then exit. It will never check for a combination of Fizz and Buzz.
                if(isFizz && isBuzz)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(isBuzz)
                {
                    Console.WriteLine("Buzz");
                }
                else if(isFizz)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
