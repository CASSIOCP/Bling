namespace Bling
{
    public static class Challenge3
    {
        /// <summary>
        /// Gets the approximate number of days between two dates.
        /// </summary>
        /// <param name="startingDate"></param>
        /// <param name="endingDate"></param>
        /// <returns>The number of days.</returns>
        public static int DaysBetween(string startingDate, string endingDate)
        {
            int day1 = GetDay(startingDate);
            int month1 = GetMonth(startingDate);
            int year1 = GetYear(startingDate);

            int day2 = GetDay(endingDate);
            int month2 = GetMonth(endingDate);
            int year2 = GetYear(endingDate);

            int resultingYear = year2 - year1;
            int resultingMonth = month2 - month1;
            int resultingDay = day2 - day1;

            if (resultingDay < 0)
                resultingDay *= -1;

            if (resultingMonth < 0)
                resultingMonth *= -1;

            if (resultingYear < 0)
                resultingYear *= -1;

            return resultingDay + (resultingMonth * 30) + (resultingYear * 365);
        }

        private static int GetDay(string startingDate) => startingDate[0] * 10 + startingDate[1];
        private static int GetMonth(string startingDate) => startingDate[3] * 10 + startingDate[4];
        private static int GetYear(string startingDate) => startingDate[6] * 1000 + startingDate[7] * 100 + startingDate[8] * 10 + startingDate[9];
    }
}