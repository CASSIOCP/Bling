namespace Bling
{
    public static class Challenge2
    {
        private static bool IsEven(int number) => number % 2 == 0;

        /// <summary>
        /// Reorder an array by ascending order for even numbers and descending order for odd numbers.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>A reordered array.</returns>
        public static int[] ReorderArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if ((IsEven(array[i]) && IsEven(array[j]) && array[i] > array[j]) || (!IsEven(array[i]) && IsEven(array[j])))
                    {

                        int aux = array[j];
                        array[j] = array[i];
                        array[i] = aux;
                    }
                    else if ((!IsEven(array[i]) && !IsEven(array[j]) && array[i] < array[j]))
                    {
                        int aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }

            return array;
        }
    }
}