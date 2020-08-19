using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewWhiteboardSamples.StringManipulation
{
    public class Swap2Numbers
    {
        public static void Swap(ref int x, ref int y)
        {
            var placeholder = x;
            x = y;
            y = placeholder;
        }
    }
}
