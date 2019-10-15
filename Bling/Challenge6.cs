namespace Bling
{
    public static class Challenge6
    {
        /// <summary>
        /// Get the total overlapped area of two rectangles.
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns>An interger representing the overlapped area.</returns>
        public static int GetOverlappedAreaOfRectangles(Rectangle r1, Rectangle r2)
        {
            Point TopLeftPointA = GetTopLeftPoint(r1);
            Point BottomRightPointA = GetBottomRightPoint(r1);

            Point TopLeftPointB = GetTopLeftPoint(r2);
            Point BottomRightPointB = GetBottomRightPoint(r2);

            if (HasOverlap(TopLeftPointA, BottomRightPointA, TopLeftPointB, BottomRightPointB))
            {
                return CalculateOverlappedArea(TopLeftPointA, BottomRightPointA, TopLeftPointB, BottomRightPointB);
            }

            return 0;
        }

        private static int CalculateOverlappedArea(Point TopLeftPointA, Point BottomRightPointA, Point TopLeftPointB, Point BottomRightPointB)
        {
            int overlappedArea =
                (LowestValue(BottomRightPointA.X, BottomRightPointB.X) - HighestValue(TopLeftPointA.X, TopLeftPointB.X)) *
                (HighestValue(BottomRightPointA.Y, BottomRightPointB.Y) - LowestValue(TopLeftPointA.Y, TopLeftPointB.Y));

            if (overlappedArea < 0)
                overlappedArea *= -1;

            return overlappedArea;
        }

        private static int LowestValue(int v1, int v2)
        {
            return (v1 <= v2) ? v1 : v2;
        }

        private static int HighestValue(int v1, int v2)
        {
            return (v1 >= v2) ? v1 : v2;
        }

        private static bool HasOverlap(Point TopLeftPointA, Point BottomRightPointA, Point TopLeftPointB, Point BottomRightPointB)
        {
            return
                TopLeftPointA.X <= BottomRightPointB.X &&
                TopLeftPointB.X <= BottomRightPointA.X &&
                TopLeftPointA.Y >= BottomRightPointB.Y &&
                TopLeftPointB.Y >= BottomRightPointA.Y;
        }

        private static Point GetTopLeftPoint(Rectangle rectangle)
        {
            return
                CompareTopLeftPoints(
                    CompareTopLeftPoints(
                        CompareTopLeftPoints(rectangle.A, rectangle.B),
                        rectangle.C),
                    rectangle.D);
        }

        private static Point GetBottomRightPoint(Rectangle rectangle)
        {
            return
                CompareBottomRightPoints(
                    CompareBottomRightPoints(
                        CompareBottomRightPoints(rectangle.A, rectangle.B),
                        rectangle.C),
                    rectangle.D);
        }

        private static Point CompareTopLeftPoints(Point p1, Point p2)
        {
            return (p1.X <= p2.X && p1.Y >= p2.Y) ? p1 : p2;
        }

        private static Point CompareBottomRightPoints(Point p1, Point p2)
        {
            return (p1.X >= p2.X && p1.Y <= p2.Y) ? p1 : p2;
        }
    }
}