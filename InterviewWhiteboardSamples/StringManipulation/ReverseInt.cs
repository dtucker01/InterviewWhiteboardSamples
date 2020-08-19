using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewWhiteboardSamples.StringManipulation
{
    // --- Directions
    // Given an integer, return an integer that is the reverse
    // ordering of numbers.
    // --- Examples
    //   reverseInt(15) === 51
    //   reverseInt(981) === 189
    //   reverseInt(500) === 5
    //   reverseInt(-15) === -51
    //   reverseInt(-90) === -9

    public static class ReverseInt
    {
       
        internal static int ReverseInt1(int n)
        {
            int left = n;
            int rev = 0;
            while (Convert.ToBoolean(left)) // instead of left>0 , to reverse signed numbers as well
            {
               var r = left % 10;
                rev = rev * 10 + r;
                left = left / 10;  //left = Math.floor(left / 10); 
            }

            return rev;
        }
    }
}
