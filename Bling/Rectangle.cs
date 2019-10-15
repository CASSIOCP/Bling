namespace Bling
{
    public struct Rectangle
    {
        public Rectangle(Point a, Point b, Point c, Point d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public Point A;
        public Point B;
        public Point C;
        public Point D;
    }
}