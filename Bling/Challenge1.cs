namespace Bling
{
    public static class Challenge1
    {
        public enum Direction
        {
            Left,
            Right
        }

        /// <summary>
        /// Rotate an array in x number of positions based on the direction.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="rotations"></param>
        /// <param name="direction"></param>
        /// <returns>A rotated array.</returns>
        public static int[] RotateArray(int[] array, int rotations, Direction direction)
        {
            if (rotations <= 0 || array.Length <= 1 || (rotations % array.Length == 0))
                return array;

            if (array.Length % 2 == 0 && array.Length / 2 == rotations)
            {
                InvertHalfArray(array, rotations);

                return array;
            }

            if (direction == Direction.Right)
            {
                MoveRight(array);
            }
            else
            {
                MoveLeft(array);
            }

            RotateArray(array, --rotations, direction);

            return array;
        }

        private static void InvertHalfArray(int[] array, int rotations)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int aux = array[i + rotations];
                array[i + rotations] = array[i];
                array[i] = aux;
            }
        }

        private static void MoveLeft(int[] array)
        {
            int aux = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = aux;
        }

        private static void MoveRight(int[] array)
        {
            int aux = array[array.Length - 1];

            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = aux;
        }
    }
}