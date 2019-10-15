namespace Bling
{
    public static class Challenge4
    {
        /// <summary>
        /// Identify all possible combinations of the 6 given integers to form triangles.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="f"></param>
        /// <returns>The combination of numbers that form the triangles and its type</returns>
        public static string GetTriangles(int a, int b, int c, int d, int e, int f)
        {
            int[] array = new int[6] { a, b, c, d, e, f };

            string triangles = "";

            for (int i = 0; i < array.Length - 2; i++)
            {
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    for (int k = j + 1; k < array.Length; k++)
                    {
                        triangles += ValidateTriangle(array[i], array[j], array[k]);
                    }
                }
            }

            return triangles;
        }

        private static string ValidateTriangle(int a, int b, int c)
        {
            if (a + b <= c || a + c <= b || c + b <= a)
            {                
                return null; //Not a triangle
            }

            if (a == b && a == c)
            {
                return $"[{a}, {b}, {c}]: Equilateral\n";
            }

            if (a == b || b == c || a == c)
            {
                return $"[{a}, {b}, {c}]: Isosceles\n";
            }
                        
            return $"[{a}, {b}, {c}]: Scalene\n";            
        }
    }
}