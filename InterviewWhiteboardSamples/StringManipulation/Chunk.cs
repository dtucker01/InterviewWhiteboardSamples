using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewWhiteboardSamples.StringManipulation
{
    // --- Directions
    // Given an array and chunk size, divide the array into many subarrays
    // where each subarray is of length size
    // --- Examples
    // chunk([1, 2, 3, 4], 2) --> [[ 1, 2], [3, 4]]
    // chunk([1, 2, 3, 4, 5], 2) --> [[ 1, 2], [3, 4], [5]]
    // chunk([1, 2, 3, 4, 5, 6, 7, 8], 3) --> [[ 1, 2, 3], [4, 5, 6], [7, 8]]
    // chunk([1, 2, 3, 4, 5], 4) --> [[ 1, 2, 3, 4], [5]]
    // chunk([1, 2, 3, 4, 5], 10) --> [[ 1, 2, 3, 4, 5]]
    public static class Chunk
    {
        //public static void ChunkIt(int[] source, int size)
        //{
        //    int[] buffer;
        //    int[] test = new int[2];

        //    for (int i = 0; i < source.Length; i += size)
        //    {
        //        //buffer = new int[2];
        //        int[] last = test[test.Length - 1];


        //        if (!buffer || buffer.Length == size)


        //        Array.Copy(source, i, buffer, 0, 2);
        //        // process array
        //        Array.Copy(source, i, test, i, 2);
        //    }


        //}

        public static IEnumerable<IEnumerable<T>> Split<T>(this T[] array, int size)
        {
            for (var i = 0; i < (float)array.Length / size; i++)
            {
                yield return array.Skip(i * size).Take(size);
            }
        }
    }
}
