namespace Bling
{
    public static class Challenge5
    {
        /// <summary>
        /// Check if a string exists in text.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="substring"></param>
        /// <returns>Return true if a string was found or false otherwise.</returns>
        public static bool Substring(string text, string substring)
        {
            if (text.Length == 0 || substring.Length == 0 || text.Length < substring.Length)
                return false;

            int index = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == substring[index])
                {
                    if (index + 1 == substring.Length)
                        return true;

                    index++;
                }
                else
                {
                    index = 0;
                }
            }

            return false;
        }
    }
}