using System;

namespace Bling
{
    public static class ArrayHelper
    {
        /// <summary>
        /// Print all array elements
        /// </summary>
        /// <param name="array"></param>
        public static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}